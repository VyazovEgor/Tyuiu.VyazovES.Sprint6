using Tyuiu.VyazovES.Sprint6.Task0.V16.Lib;

namespace Tyuiu.VyazovES.Sprint6.Task0.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x;
            DataService ds = new DataService();
            try
            {
                x = Convert.ToInt32(textBoxX.Text);
                double res = ds.Calculate(x);
                textBoxResult.Text = res.ToString();
            }
            catch
            {
                MessageBox.Show("¬ведены неверные данные", "ќшибка", MessageBoxButtons.OK);

            }

        }
    }
}
