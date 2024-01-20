using System.Collections;

namespace Sudoku_Builder
{
    public class Row : IList<Cell>
    {
        private List<Cell> _row;

        //creates a row object populated with unique numbers 1-9
        public Row()
        {
            _row = new List<Cell>();
            for (int i = 0; i < 9; i++)
            {
                var cell = new Cell();
                var valid = false;
                while (!valid)
                {
                    int tempValue = GenValue();
                    foreach (Cell c in _row)
                    {
                        if (c.Value == tempValue)
                        {
                            valid = false;
                        }
                        else
                        {
                            valid = true;
                        }
                    }                
                }
            }
        }

        public Cell GetCell(int index)
        {
            var cell = _row[index];
            return cell;
        }

        private int GenValue()
        {
            Random random = new Random();
            var value = random.Next(1, 10);
            return value;
        }

        public Cell this[int index] { get => ((IList<Cell>)_row)[index]; set => ((IList<Cell>)_row)[index] = value; }

        public int Count => ((ICollection<Cell>)_row).Count;

        public bool IsReadOnly => ((ICollection<Cell>)_row).IsReadOnly;

        public void Add(Cell item)
        {
            ((ICollection<Cell>)_row).Add(item);
        }

        public void Clear()
        {
            ((ICollection<Cell>)_row).Clear();
        }

        public bool Contains(Cell item)
        {
            return ((ICollection<Cell>)_row).Contains(item);
        }

        public void CopyTo(Cell[] array, int arrayIndex)
        {
            ((ICollection<Cell>)_row).CopyTo(array, arrayIndex);
        }

        public IEnumerator<Cell> GetEnumerator()
        {
            foreach (Cell cell in _row)
            { 
                yield return cell;
            }
        }

        public int IndexOf(Cell item)
        {
            return ((IList<Cell>)_row).IndexOf(item);
        }

        public void Insert(int index, Cell item)
        {
            ((IList<Cell>)_row).Insert(index, item);
        }

        public bool Remove(Cell item)
        {
            return ((ICollection<Cell>)_row).Remove(item);
        }

        public void RemoveAt(int index)
        {
            ((IList<Cell>)_row).RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
    }
}