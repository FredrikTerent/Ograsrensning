using OgraasApi.Models;

namespace OgraasApi.Data
{
    public class Coordinates
    {
        public int Id { get; set; }
        public int BoardId { get; set; }    
        public int row { get; set; }
        public int col { get; set; }
        public Cell cell { get; set; }
    }
}
