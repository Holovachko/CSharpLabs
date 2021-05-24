using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = (int)numericUpDown1.Value;
            dataGridView1.RowCount = 1;
        }

        private void згенеруватиМасивToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                dataGridView1[i, 0].Value = rand.Next(-100, 100);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = (int)numericUpDown1.Value;
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void кстьПарнихЕлементівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int countNum = 0;
            int[] arr = new int[(int)numericUpDown1.Value];
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                if (Convert.ToInt32(dataGridView1[i, 0].Value) % 2 == 0)
                {
                    arr[i] = Convert.ToInt32(dataGridView1[i, 0].Value);
                    countNum++;
                }
            }
            label2.Text = countNum.ToString();

        }

        private void зберегтиФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                BinaryWriter bw = new BinaryWriter(File.Open("NP.dat", FileMode.Create));
                bw.Write((int)numericUpDown1.Value);
                for(int i = 0; i < numericUpDown1.Value; i++)
                {
                    if(Convert.ToInt32(dataGridView1[i,0].Value) % 2 != 0) 
                    {
                        bw.Write(Convert.ToInt32(dataGridView1[i, 0].Value));
                    }
                }
                bw.Close();
            }
        }

        private void завантажитиФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                BinaryReader br = new BinaryReader(File.Open(openFileDialog1.FileName, FileMode.Open));
                dataGridView1.ColumnCount = br.ReadInt32();
                while (br.PeekChar() > -1)
                {
                    for(int i = 0; i < numericUpDown1.Value; i++)
                    {
                        dataGridView1[i, 0].Value = br.ReadInt32();
                    }


                }
                br.Close();

            }
        }
    }
}
