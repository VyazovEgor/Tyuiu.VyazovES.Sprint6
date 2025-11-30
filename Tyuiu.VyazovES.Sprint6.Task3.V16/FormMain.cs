using Tyuiu.VyazovES.Sprint6.Task3.V16.Lib;

namespace Tyuiu.VyazovES.Sprint6.Task3.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        int[,] mtrx = new int[5, 5] {
              { 14,   1,  -3,   1,  10},

              { 7,  -3, 5,  -4,   0},

             { -10, -19, -18,  -9,  19},

             { -2,  -2, -16, 2, -17},

             { -16,   9,   5, -10,  16},

        };

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewResult.ColumnCount = columns;
            dataGridViewResult.RowCount = rows;


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewResult.Rows.Clear();
            dataGridViewResult.Columns.Clear();

            mtrx = ds.Calculate(mtrx);
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;
            dataGridViewResult.ColumnCount = columns;
            dataGridViewResult.RowCount = rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }
    }
}
