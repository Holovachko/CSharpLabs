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
using System.Runtime.Serialization.Formatters.Binary;

namespace Ex3
{
    public partial class Form1 : Form
    {
        List<Storage> classes = new List<Storage>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Storage f1 = new Storage(textBox1.Text , Convert.ToInt32(textBox2.Text) , Convert.ToInt32(textBox3.Text));
            classes.Add(f1);
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream(saveFileDialog1.FileName , FileMode.Create);
            bf.Serialize(fs , classes);
            fs.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open);
            Storage f2 = (Storage)bf.Deserialize(fs);
            richTextBox1.Text = $"{f2.name} {f2.price}{ f2.count}";
            fs.Close();
        }
    }
}
