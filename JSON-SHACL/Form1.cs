using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSON_SHACL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textVerify.Text = "Waiting!";
            textVerify.ForeColor = System.Drawing.Color.White;
            fileText.Text = "No file selected";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Global.verificar(textBox1,textVerify);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                string filename = openFileDialog1.FileName;
                string readfile = File.ReadAllText(filename);
                textBox1.Text = readfile;
                fileText.Text = filename;
            }
            catch
            {

            }
            
        }
    }
}
