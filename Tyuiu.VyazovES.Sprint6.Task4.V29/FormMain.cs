using System.Drawing.Configuration;
using Tyuiu.VyazovES.Sprint6.Task4.V29.Lib;

namespace Tyuiu.VyazovES.Sprint6.Task4.V29
{
    public partial class Form1 : Form
    {
        public Form1()
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
                textBoxResult.AppendText("|   X     |    f(x)    | " + Environment.NewLine);
                textBoxResult.AppendText("|---------------| " + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    strline = string.Format("|{0,5:d}    |    {1, 5:f2} |", a, array[i]);
                    textBoxResult.AppendText(strline + Environment.NewLine);
                    a++;

                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V29.txt";
                File.WriteAllText(path, textBoxResult.Text);

                DialogResult dialogResult =  MessageBox.Show($"Файл сохранен успешно", "Успех!", MessageBoxButtons.OK);

                if (dialogResult == DialogResult.OK) { 
                
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}");
            }
        }
    }
}

