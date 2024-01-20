using System.Collections;

namespace Sudoku_Builder
{
    public class Column : IList<Cell>
    {
        private List<Cell> _column;

        public Column(List<Cell> column)
        {
            _column = column;
        }

        public Cell this[int index] { get => ((IList<Cell>)_column)[index]; set => ((IList<Cell>)_column)[index] = value; }

        public int Count => ((ICollection<Cell>)_column).Count;

        public bool IsReadOnly => ((ICollection<Cell>)_column).IsReadOnly;

        public void Add(Cell item)
        {
            ((ICollection<Cell>)_column).Add(item);
        }

        public void Clear()
        {
            ((ICollection<Cell>)_column).Clear();
        }

        public bool Contains(Cell item)
        {
            return ((ICollection<Cell>)_column).Contains(item);
        }

        public void CopyTo(Cell[] array, int arrayIndex)
        {
            ((ICollection<Cell>)_column).CopyTo(array, arrayIndex);
        }

        public IEnumerator<Cell> GetEnumerator()
        {
            foreach (Cell cell in _column)
            {
                yield return cell;
            }
        }

        public int IndexOf(Cell item)
        {
            return ((IList<Cell>)_column).IndexOf(item);
        }

        public void Insert(int index, Cell item)
        {
            ((IList<Cell>)_column).Insert(index, item);
        }

        public bool Remove(Cell item)
        {
            return ((ICollection<Cell>)_column).Remove(item);
        }

        public void RemoveAt(int index)
        {
            ((IList<Cell>)_column).RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
    }
}