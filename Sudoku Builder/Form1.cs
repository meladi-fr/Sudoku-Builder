using System.Diagnostics;

namespace Sudoku_Builder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            designGrid();

            //Figuring out logic in console first
            var board = new Board();
            var boardList = "";
            int row = 0;

            foreach (Cell cell in board)
            {
                boardList += cell.Value.ToString();
                row++;

                if (row > 8)
                {
                    boardList += "\r\n";
                    row = 0;
                }
            }

            Debug.WriteLine(boardList);
        }

        private void designGrid()
        {
            //set up layout of sudoku dataviewgrid
            const int colWidth = 59;
            const int rowHeight = 59;

            sGrid.AllowUserToAddRows = false;
            sGrid.AllowUserToDeleteRows = false;
            sGrid.AllowUserToResizeColumns = false;
            sGrid.AllowUserToResizeRows = false;
            sGrid.RowHeadersVisible = false;
            sGrid.ColumnHeadersVisible = false;
            sGrid.ScrollBars = ScrollBars.None;
        }

        
    }
}
