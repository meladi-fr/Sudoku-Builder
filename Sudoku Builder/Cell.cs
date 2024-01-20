using System.Collections;

namespace Sudoku_Builder
{
    public class Cell
    {
        public int Value { get; set; }
        public int Row { get; set; }
        public int Column { get; set; } 
        public int Sector { get; set; }
    }
}