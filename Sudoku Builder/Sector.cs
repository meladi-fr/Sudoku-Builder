using System.Collections;

namespace Sudoku_Builder
{
    public class Sector : IList<Cell>
    {
        private List<Cell> _sector;

        public Sector()
        {
            //creates a sector object populated with nine zero-value cells
            _sector = new List<Cell>();
            for (int i = 0; i < 9; i++)
            {
                _sector.Add(new Cell());
            }
        }

        public Sector(List<Cell> sector)
        {
            _sector = sector;
        }

        public Cell this[int index] { get => ((IList<Cell>)_sector)[index]; set => ((IList<Cell>)_sector)[index] = value; }

        public int Count => ((ICollection<Cell>)_sector).Count;

        public bool IsReadOnly => ((ICollection<Cell>)_sector).IsReadOnly;

        public void Add(Cell item)
        {
            ((ICollection<Cell>)_sector).Add(item);
        }

        public void Clear()
        {
            ((ICollection<Cell>)_sector).Clear();
        }

        public bool Contains(Cell item)
        {
            return ((ICollection<Cell>)_sector).Contains(item);
        }

        public void CopyTo(Cell[] array, int arrayIndex)
        {
            ((ICollection<Cell>)_sector).CopyTo(array, arrayIndex);
        }

        public IEnumerator<Cell> GetEnumerator()
        {
            foreach (Cell cell in _sector)
            {
                yield return cell;
            }
        }

        public int IndexOf(Cell item)
        {
            return ((IList<Cell>)_sector).IndexOf(item);
        }

        public void Insert(int index, Cell item)
        {
            ((IList<Cell>)_sector).Insert(index, item);
        }

        public bool Remove(Cell item)
        {
            return ((ICollection<Cell>)_sector).Remove(item);
        }

        public void RemoveAt(int index)
        {
            ((IList<Cell>)_sector).RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
    }
}