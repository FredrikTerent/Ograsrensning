using OgraasApi.Models;

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
            for (int rad  = 0; rad < 9; rad++)
            {
                for (int col  = 0; col < 9; col++)
                {
                    coordinates.Add(new Coordinates() { row = rad, col = col, cell = board.Cells[rad, col], BoardId = board.Id });
                }
            }
            context.Add(board);
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
            throw new NotImplementedException();
        }

        public async Task<Board> GetByIdAsync(int id)
        {
            var board = await context.Boards.FindAsync(id);
            List<Coordinates> coordinates = context.Coordinates.Where(c=>c.BoardId == board.Id).OrderBy(s=>s.Id).ToList();

        }

        public async Task<Board> UpdateAsync(Board board)
        {
            throw new NotImplementedException();
        }
    }
}
