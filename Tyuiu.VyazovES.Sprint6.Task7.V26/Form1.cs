using System;
using System.Drawing.Configuration;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Tyuiu.VyazovES.Sprint6.Task7.V26.Lib;

namespace Tyuiu.VyazovES.Sprint6.Task7.V26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int rows, columns;
        string openFilePath;
        DataService ds = new DataService();

        public int[,] LoadFromFile(string filepath)
        {
            try
            {
                // „итаем все строки из файла
                string fileData = File.ReadAllText(filepath);

                fileData = fileData.Replace('\n', '\r');
                string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

                rows = lines.Length;
                columns = lines[0].Split(';').Length;

                int[,] array = new int[rows, columns];

                for (int r = 0; r < rows; r++)
                {
                    string[] line_r = lines[r].Split(';');

                    for (int c = 0; c < columns; c++)
                    {
                        array[r, c] = Convert.ToInt32(line_r[c]); 
                    }

                }
                return array;
            }
            catch (Exception)
            {
                return new int[0, 0];
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                openFilePath = openFileDialog1.FileName;

                int[,] array = new int[rows, columns];

                array = LoadFromFile(openFilePath);

                dataGridView1.ColumnCount = columns;
                dataGridView1.RowCount = columns;
                dataGridView2.ColumnCount = columns;
                dataGridView2.RowCount = columns;


                for (int i = 0; i < columns; i++)
                {
                    dataGridView1.Columns[i].Width = 25;
                    dataGridView2.Columns[i].Width = 25;

                }

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridView1.Rows[r].Cells[c].Value = array[r, c];

                    }

                }
                int[,] array2 = new int[rows, columns];
                array2 = ds.GetMatrix(openFilePath);

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridView2.Rows[r].Cells[c].Value = array2[r, c];

                    }

                }



            }
            catch
            {
                MessageBox.Show("¬ведены неверные данные", "ќшибка", MessageBoxButtons.OK);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.FileName = "OutPutFileTask7.csv";
                saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
                saveFileDialog1.ShowDialog();

                string path = saveFileDialog1.FileName;

                FileInfo fileInfo = new FileInfo(path);
                bool fileExists = fileInfo.Exists;

                if (fileExists)
                {
                    File.Delete(path);
                }

                rows = dataGridView1.RowCount;
                columns = dataGridView1.ColumnCount;

                string str = "";

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (j != columns - 1)
                        {
                            str = str + dataGridView1.Rows[i].Cells[j].Value + ";";
                        }
                        else 
                        {
                            str = str + dataGridView1.Rows[i].Cells[j].Value;
                        }
                        

                    }
                    File.AppendAllText(path, str + Environment.NewLine);
                    str = "";
                }
               


            }
            catch
            {
                MessageBox.Show("¬ведены неверные данные", "ќшибка", MessageBoxButtons.OK);
            }

        }

    }
}

