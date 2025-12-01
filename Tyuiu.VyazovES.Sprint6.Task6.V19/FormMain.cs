using System;
using System.Drawing.Configuration;
using Tyuiu.VyazovES.Sprint6.Task6.V19.Lib;

namespace Tyuiu.VyazovES.Sprint6.Task6.V19
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        private void button1_Click(object sender, EventArgs e)
        {
            try {
                openFileDialog1.ShowDialog();
                openFilePath = openFileDialog1.FileName;
                textBox1.Text = File.ReadAllText(openFilePath);
                textBox2.Text = ds.CollectTextFromFile(openFilePath);
                
            }
            catch
            {
                MessageBox.Show("¬ведены неверные данные", "ќшибка", MessageBoxButtons.OK);
            }

        }
      
    }
}

