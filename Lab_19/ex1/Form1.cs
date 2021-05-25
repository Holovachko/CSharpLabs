using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 1;
            dataGridView1.ColumnCount = (int)numericUpDown1.Value;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = (int)numericUpDown1.Value;
        }

        private void генераціяМатриціToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                dataGridView1[i, 0].Value = rnd.Next(-100, 100);
            }
            for(int i = 0; i < numericUpDown1.Value; i++){
                if ((int)dataGridView1[i,0].Value > 0)
                {
                    chart1.Series[0].Points.AddXY(i, Convert.ToInt32(dataGridView1[i, 0].Value));
                }
            }
            
        }

        private void зберегтиФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //1
                    StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                    //2
                    sw.WriteLine((int)numericUpDown1.Value);
                    for (int i = 0; i < numericUpDown1.Value; i++)
                    {
                        if ((int)dataGridView1[i, 0].Value < 0)
                        {
                            sw.WriteLine(dataGridView1[i, 0].Value);
                        }
                    }
                    //3
                    sw.Close();
                }
            }
            catch(Exception Overflow)
            {

            }
        }

        private void завантажитиФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //1
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                //2
                numericUpDown1.Value = Convert.ToInt32(sr.ReadLine());
                for (int i = 0; i < numericUpDown1.Value; i++)
                {
                    dataGridView1[i, 0].Value = sr.ReadLine();
                }
                //3
                sr.Close();
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}

