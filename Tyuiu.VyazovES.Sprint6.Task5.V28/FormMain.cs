using System.Drawing.Configuration;
using Tyuiu.VyazovES.Sprint6.Task5.V28.Lib;

namespace Tyuiu.VyazovES.Sprint6.Task5.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }


        DataService ds = new DataService();

        string path = @"C:\Users\webpunk\Downloads\Sprint6Task5\Sprint6Task5\InPutFileTask5V28.txt";
        private void button1_Click(object sender, EventArgs e)
        {

                dataGridView1.ColumnCount = 2;
                dataGridView1.Columns[0].Width = 20;
                dataGridView1.Columns[1].Width = 50;
               
                string strline;
                DataService ds = new DataService();
                double[] array;
                array = new double[ds.len];
                array = ds.LoadFromDataFile(path);


                this.chart1.ChartAreas[0].AxisX.Title = "Îñü X";
                this.chart1.ChartAreas[0].AxisY.Title = "Îñü Y";
                chart1.Series[0].Points.Clear();

                for (int i = 0; i < array.Length; i++)
                {
                    dataGridView1.Rows.Add(Convert.ToString(i), Convert.ToString(array[i]));
                    this.chart1.Series[0].Points.AddXY(i, array[i]);

                }

        }

    }
}

