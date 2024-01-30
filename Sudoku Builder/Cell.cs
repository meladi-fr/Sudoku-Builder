using System.Collections;

namespace Sudoku_Builder
{
    public class Cell
    {
        public int Value { get; set; }
        public int Row { get; set; }
        public int Column { get; set; } 
        public int Sector { get; set; }

        public Cell() 
        {
            this.Sector = 0;
            this.Value = 0; 
            this.Row = 0;   
            this.Column = 0;    
        }
    }
}