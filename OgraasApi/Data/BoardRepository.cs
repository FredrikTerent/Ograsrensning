using Microsoft.AspNetCore.Mvc.Diagnostics;
using Microsoft.EntityFrameworkCore;
using OgraasApi.Migrations;
using OgraasApi.Models;
using System.Collections.Generic;

namespace OgraasApi.Data
{
    public class BoardRepository : IBoard
    {
        private readonly ApplicationDbContext context;

        public BoardRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<Board> CreateAsync(Board board)
        {     
            List<Coordinates> coordinates = new List<Coordinates>();
            context.Add(board);
            for (int rad  = 0; rad <= 9; rad++)
            {
                for (int col  = 0; col <= 9; col++)
                {
                    coordinates.Add(new Coordinates() { row = rad, col = col, cell = board.Cells[rad, col], BoardId = board.Id });
                }
            }
            context.Add(coordinates);
            await context.SaveChangesAsync();

            return board;
        }

        public async Task DeleteAsync(int id)
        {
            var board = context.Boards.FindAsync(id);

            context.Remove(board);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Board>> GetAllAsync()
        {
            var boardList = await context.Boards.OrderBy(x => x.Id).ToListAsync();
            foreach (var board in boardList)
            {
                List<Coordinates> coordinates = context.Coordinates.Where(c => c.BoardId == board.Id).OrderBy(s => s.Id).ToList();
                foreach (var coord in coordinates)
                {
                    board.Cells[coord.row, coord.col] = coord.cell;
                }
            }
            return boardList;
        }

        public async Task<Board> GetByIdAsync(int id)
        {
            var board = await context.Boards.FindAsync(id);
            List<Coordinates> coordinates = context.Coordinates.Where(c=>c.BoardId == board.Id).OrderBy(s=>s.Id).ToList();
            
            foreach (var coord in coordinates)
            {
                board.Cells[coord.row, coord.col] = coord.cell;
            }
            return board;
        }

        public async Task<Board> UpdateAsync(Board board)
        {
            var oldCoord = context.Coordinates.Where(c => c.BoardId == board.Id).OrderBy(s => s.Id).ToList();
            List<Coordinates> coordinates = new List<Coordinates>();
            for (int rad = 0; rad <= 9; rad++)
            {
                for (int col = 0; col <= 9; col++)
                {
                    var oldCell = oldCoord.Find(c => c.row == rad && c.col == col);
                    if (oldCell != null)
                    {
                        oldCell.cell = board.Cells[rad, col];
                    }
                    //else
                    //{

                    //    context.Coordinates.Add(new Coordinates() { row = rad, col = col, cell = board.Cells[rad, col], BoardId = board.Id });
                    //}

                }
            }
            context.Update(board);
            await context.SaveChangesAsync();

            return board;
        }
    }
}
