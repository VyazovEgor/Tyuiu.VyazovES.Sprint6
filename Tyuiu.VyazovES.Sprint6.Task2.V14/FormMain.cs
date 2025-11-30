using Tyuiu.VyazovES.Sprint6.Task2.V14.Lib;

namespace Tyuiu.VyazovES.Sprint6.Task2.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string strline;
                int a = -5;
                int b = 5;
                int len = b - a + 1;
                DataService ds = new DataService();
                double[] array;
                array = new double[len];
                array = ds.GetMassFunction(a, b);
                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewResult.Rows.Add(Convert.ToString(a), Convert.ToString(array[i]));
                    a++;

                }
            }
            catch
            {
                MessageBox.Show("¬ведены неверные данные", "ќшибка", MessageBoxButtons.OK);
            }

        }
    }
}
