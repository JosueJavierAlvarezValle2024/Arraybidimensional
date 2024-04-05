namespace Arraybidimensional
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
            txtRows = new TextBox();
            txtColumns = new TextBox();
            dataGridView1 = new DataGridView();
            btnCreateMatriz = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtRows
            // 
            txtRows.Location = new Point(549, 89);
            txtRows.Name = "txtRows";
            txtRows.Size = new Size(218, 27);
            txtRows.TabIndex = 0;
            // 
            // txtColumns
            // 
            txtColumns.Location = new Point(549, 189);
            txtColumns.Name = "txtColumns";
            txtColumns.Size = new Size(218, 27);
            txtColumns.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(463, 350);
            dataGridView1.TabIndex = 2;
            // 
            // btnCreateMatriz
            // 
            btnCreateMatriz.ForeColor = Color.Red;
            btnCreateMatriz.Location = new Point(549, 274);
            btnCreateMatriz.Name = "btnCreateMatriz";
            btnCreateMatriz.Size = new Size(218, 88);
            btnCreateMatriz.TabIndex = 3;
            btnCreateMatriz.Text = "Create";
            btnCreateMatriz.UseVisualStyleBackColor = true;
            btnCreateMatriz.Click += btnCreateMatriz_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(610, 34);
            label1.Name = "label1";
            label1.Size = new Size(93, 38);
            label1.TabIndex = 4;
            label1.Text = "Rows:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(587, 133);
            label2.Name = "label2";
            label2.Size = new Size(139, 38);
            label2.TabIndex = 5;
            label2.Text = "Columns:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCreateMatriz);
            Controls.Add(dataGridView1);
            Controls.Add(txtColumns);
            Controls.Add(txtRows);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRows;
        private TextBox txtColumns;
        private DataGridView dataGridView1;
        private Button btnCreateMatriz;
        private Label label1;
        private Label label2;
    }
}
