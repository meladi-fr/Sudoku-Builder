﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_Builder
{
    public class Board : IEnumerable<Row>, IEnumerable<Column>, IEnumerable<Sector>
    {
        private List<Row> _rows;
        private List<Column> _columns;
        private List<Sector> _sectors;

        public Board() 
        {            
            _rows = new List<Row>();
            _columns = new List<Column>();
            _sectors = new List<Sector>();

            fillBoard();
        }

        private void fillBoard()
        {
            for (int r = 0; r < 9; r++)
            {
                //add new Row object to rows collection every iteration
                var newRow = new Row();
                _rows.Add(newRow);

                for (int c = 0; c < 9; c++)
                {
                    //add new Column and Sector to their respective collections each iteration, but only while the first
                    //row is populated in order to reach 9 indexes
                    if (r == 0)
                    {
                        _columns.Add(new Column());
                        _sectors.Add(new Sector());
                    }

                    var valid = false;
                    var cell = new Cell();
                    int sect = getSector(r, c);

                    while (!valid)
                    {
                        int tempVal = genCell();
                        if (isCellValid(r, c, sect, tempVal))
                        {
                            cell.Value = tempVal;
                            cell.Row = r;
                            cell.Column = c;
                            cell.Sector = sect;
                            valid = true;

                            //update corresponding cell collections with valid cell details
                            _rows[r][c] = cell;
                            _columns[c][r] = cell;
                            _sectors[sect][r] = cell;
                        }
                        else
                        {
                            valid = false;
                        }
                    }
                }
            }
        }

        private int getSector (int row, int col)
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

        private int genCell()
        {
            Random random = new Random();
            int number = random.Next(1, 10);
            return number;
        }

        private Boolean isCellValid(int row, int col, int sect, int value)
        {
            //check if a cell of this value already exists in the same row
            foreach (Cell cell in _rows[row])
            {
                if (cell.Value == value) return false;
            }

            //check if a cell of this value already exists in the same column
            foreach (Cell cell in _columns[col])
            {
                if (cell.Value == value) return false;
            }

            //check if a cell of this value already exists in the same sector
            foreach (Cell cell in _sectors[sect])
            {
                if (cell.Value == value) return false;
            }

            //none of the loops above found a duplicate number, so cell is valid
            return true;
        }


        public IEnumerator<Row> GetEnumerator()
        {
            return ((IEnumerable<Row>)_rows).GetEnumerator();
        }

        IEnumerator<Column> IEnumerable<Column>.GetEnumerator()
        {
            return ((IEnumerable<Column>)_columns).GetEnumerator();
        }

        IEnumerator<Sector> IEnumerable<Sector>.GetEnumerator()
        {
            return ((IEnumerable<Sector>)_sectors).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
    }
}
