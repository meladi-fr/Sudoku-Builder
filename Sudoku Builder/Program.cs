using System.Diagnostics;

namespace Sudoku_Builder
{
    internal static class Program
    {
        /// <summary>
        ///  This program generates a pre-solved sudoku board, then selectively hides cells based on difficulty level selected.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());


        }
    }
}