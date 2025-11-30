using Tyuiu.VyazovES.Sprint6.Task1.V5.Lib;

namespace Tyuiu.VyazovES.Sprint6.Task1.V5
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
                textBoxResult.AppendText("|   X     |    f(x)    | "+ Environment.NewLine);
                textBoxResult.AppendText("|---------------| " + Environment.NewLine);
                for (int i = 0; i <= len-1; i++)
                {
                    strline = string.Format("|{0,5:d}    |    {1, 5:f2} |", a, array[i]);
                    textBoxResult.AppendText(strline + Environment.NewLine);
                    a++;

                }
            }
            catch {
                MessageBox.Show("¬ведены неверные данные", "ќшибка", MessageBoxButtons.OK);
            }

        }
    }
}
