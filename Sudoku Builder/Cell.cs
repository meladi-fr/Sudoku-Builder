using System.Collections;

namespace Sudoku_Builder
{
    public class Cell
    {
        public int Value { get; set; }
        public int Row { get; set; }
        public int Column { get; set; } 
        public int Sector { get; set; }

        public int Gen()
        {
            Random random = new Random();
            this.Value = random.Next(1, 10);
            return this.Value;
        }
    }
}