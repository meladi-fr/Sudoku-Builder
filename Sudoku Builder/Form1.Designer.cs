namespace Sudoku_Builder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sGrid = new DataGridView();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)sGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // sGrid
            // 
            sGrid.BackgroundColor = SystemColors.Window;
            sGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            sGrid.Location = new Point(12, 11);
            sGrid.Name = "sGrid";
            sGrid.RowTemplate.Height = 60;
            sGrid.Size = new Size(540, 540);
            sGrid.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(619, 104);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(8, 8);
            dataGridView2.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 569);
            Controls.Add(dataGridView2);
            Controls.Add(sGrid);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Form1";
            Text = "Sudoku Board Builder";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)sGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView sGrid;
        private DataGridView dataGridView2;
    }
}
