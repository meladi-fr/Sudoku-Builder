using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_Builder
{
    public class Board : IEnumerable<Row>
    {
        private List<Row> _rows;
        private List<Column> _columns;
        private List<Sector> _sectors;

        public Board() 
        {            
            _rows = new List<Row>();
            _columns = new List<Column>();
            _sectors = new List<Sector>();

            //generate all cells on board through rows
            for (int i = 0; i < 9; i++)
            {
                var row = new Row();
                foreach (Cell cell in row)
                {
                    cell.Row = i;
                }
                _rows.Add(row);
            }

            //populate column objects using row index cells
            for (int i = 0; i < 9; i++)
            {
                var cells = new List<Cell>();
                foreach (Row row in _rows)
                {
                    row[i].Column = i;
                    cells.Add(row[i]);
                }
                var column = new Column(cells);
                _columns.Add(column);
            }

            //populate sector objects, using cells by row and column index in sets of 3
            _sectors.Add(buildSector(0, 0));
            _sectors.Add(buildSector(0, 3));
            _sectors.Add(buildSector(0, 6));
            _sectors.Add(buildSector(3, 0));
            _sectors.Add(buildSector(3, 3));
            _sectors.Add(buildSector(3, 6));
            _sectors.Add(buildSector(6, 0));
            _sectors.Add(buildSector(6, 3));
            _sectors.Add(buildSector(6, 6));
        }

        private Sector buildSector(int row, int col)
        {
            var cells = new List<Cell>();
            for (int r = row; r < row+3; r++)
            {
                for (int c = col; c < col+3; c++)
                {
                    cells.Add(_rows[r].GetCell(c));               }
            }

            var sector = new Sector(cells);
            return sector;
        }

        public IEnumerator<Row> GetEnumerator()
        {
            foreach (Row row in _rows)
            {
                yield return row;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
    }
}
