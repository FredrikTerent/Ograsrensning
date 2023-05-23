using System.ComponentModel.DataAnnotations.Schema;

namespace OgraasApi.Models
{
    public class Board
    {

        public int Id { get; set; }
        public Random random = new Random();
        [NotMapped]
        public Cell[,] Cells { get; set; } = new Cell[10, 10];
        public List<Weed> Weeds = new()
        {
            new Maskros(),
            new Kardborre(),
            new Kardborre(),
            new Kvickrot(),
            new Kvickrot(),
            new Kvickrot(),
            new Kirskal(),
            new Kirskal(),
            new Kirskal(),
            new Kirskal()
        };

        public Board()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Cells[i, j] = new Cell();
                    //weed eller inte
                }
            }

            foreach (var w in Weeds)
            {
                bool Error = true;
                while (Error)
                {
                    int direction = random.Next(1, 100) % 2;// 0 vertikal, allt annat horizontal
                    var rowNumberStart = random.Next(0, 10);
                    var colNumberStart = random.Next(0, 10);
                    var rowNumberEnd = rowNumberStart;
                    var colNumberEnd = colNumberStart;
                    //if cell redan har en weed -> ny random

                    //if vertikal
                    if (direction == 0)
                    {
                        rowNumberEnd = rowNumberStart + w.Width;
                    }
                    //if horisontell
                    else
                    {
                        colNumberEnd = colNumberEnd + w.Width;
                    }

                    //Hålla sig inom spelplanen
                    if (rowNumberEnd > 9 || colNumberEnd > 9)
                    {
                        Error = true;
                        continue;
                    }

                    //Kolla om Cell är upptagen
                    List<Cell> targetCells = new();

                    for (int i = rowNumberStart; i <= rowNumberEnd; i++)
                    {
                        for (int j = colNumberStart; j <= colNumberEnd; j++)
                        {
                            targetCells.Add(Cells[i, j]);
                        }
                    }

                    if(targetCells.Any(x => x.IsOccupied))
                    {
                        Error = true;
                        continue;
                    }

                    //Placera ut ogräs
                    foreach(var cell in targetCells)
                    {
                        cell.Weed = w;
                    }
                    Error = false;
                }
            }
        }
    }
}
