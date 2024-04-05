namespace Arraybidimensional

{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int[,] matriz;
        private void btnCreateMatriz_Click(object sender, EventArgs e)
        {
            int rows = Convert.ToInt32(txtRows.Text);
            int columns = Convert.ToInt32(txtColumns.Text);

            matriz = new int[rows, columns];

            
            Random rnd = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matriz[i, j] = rnd.Next(1, 100); 
                }
            }

            ShowMatrix();

        }

        private void ShowMatrix()
        {
            if (matriz != null)
            {
                int rows = matriz.GetLength(0);
                int columns = matriz.GetLength(1);

                dataGridView1.RowCount = rows;
                dataGridView1.ColumnCount = columns;

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = matriz[i, j];
                    }
                }
            }
        }
    }
}
