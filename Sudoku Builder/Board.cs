using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_Builder
{
    public class Board : IEnumerable 
    {
        private Cell[,]? _board;

        public Board()
        {
            _board = new Cell[9, 9];

            FillBoard(_board);
        }

        private bool FillBoard(Cell[,] board)
        {
            for (int r = 0; r < 9; r++)
            {
                for (int c = 0; c < 9; c++)
                {
                    //var valid = false;
                    var cell = new Cell();
                    int sect = GetSector(r, c);

                    if (board[r, c] == null)
                    {
                        for (int v = 1; v <= 9; v++)
                        {
                            //int tempVal = genCell();
                            if (IsCellValid(board, r, c, v))
                            {
                                cell.Value = v;
                                cell.Row = r;
                                cell.Column = c;
                                cell.Sector = sect;

                                board[r, c] = cell;

                                if (FillBoard(board))
                                    return true;
                                else 
                                    board[r, c] = null;
                            }
                        }
                        return false;
                    }            
                }
            }
            _board = board;
            return true;
        }

        private int GetSector (int row, int col)
        {
            int sector = 0;
            
            if (row < 3 && col < 3) { sector = 0; }
            else if (row < 3 && col < 6) { sector = 1; }
            else if (row < 3 && col < 9) { sector = 2; }
            else if (row < 6 && col < 3) { sector = 3; }
            else if (row < 6 && col < 6) { sector = 4; }
            else if (row < 6 && col < 9) { sector = 5; }
            else if (row < 9 && col < 3) { sector = 6; }
            else if (row < 9 && col < 6) { sector = 7; }
            else if (row < 9 && col < 9) { sector = 8; }

            return sector;
        }

        //private int genCell()
        //{
        //    Random random = new Random();
        //    int number = random.Next(1, 10);
        //    return number;
        //}

        private Boolean IsCellValid(Cell[,] board, int row, int col, int value)
        {
            for (int i = 0; i < 9; i++)
            {
                //check if a cell of this value already exists in the same row
                if (board[i, col] != null && board[i, col].Value == value)  
                    return false;

                //check if a cell of this value already exists in the same column
                if (board[row, i] != null && board[row, i].Value == value)  
                    return false;                
            }

            //check if a cell of this value already exists in the same sector
            // sqRow and sqCol can only be 0, 3, or 6 
            int sqRow = row / 3 * 3; 
            int sqCol = col / 3 * 3;

            for (int r = sqRow; r < sqRow + 3; r++)
            {
                for (int c = sqCol; c < sqCol + 3; c++)
                {
                    if (board[r, c] != null && board[r,c].Value == value)
                        return false;
                }
            }

            //none of the loops above found a duplicate number, so cell is valid
            return true;
        }

        public IEnumerator GetEnumerator()
        {
            return _board.GetEnumerator();
        }

        //public IEnumerator<Row> GetEnumerator()
        //{
        //    return ((IEnumerable<Row>)_rows).GetEnumerator();
        //}

        //IEnumerator<Column> IEnumerable<Column>.GetEnumerator()
        //{
        //    return ((IEnumerable<Column>)_columns).GetEnumerator();
        //}

        //IEnumerator<Sector> IEnumerable<Sector>.GetEnumerator()
        //{
        //    return ((IEnumerable<Sector>)_sectors).GetEnumerator();
        //}

        //IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
    }
}
