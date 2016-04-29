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

namespace blocdenotas
{
    public partial class Form1 : Form
    {
        int i;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGuardar_MouseClick(object sender, MouseEventArgs e)
        {
            FileStream fs = new FileStream("bloc.txt", FileMode.Create);
      
            StreamWriter sw = new StreamWriter(fs);
            
            
                sw.WriteLine(textBox1.Text);
            
            sw.Close();
            fs.Close();
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void buttonAbrir_MouseClick(object sender, MouseEventArgs e)
        {

            StreamReader sr = new StreamReader("bloc.txt", Encoding.Default);
            // textBox1.Text = System.IO.File.ReadAllText("<RutaArchivo>\NombreArchivo");
                textBox1.Text = File.ReadAllText("bloc.txt");
            /*
            while (!sr.EndOfStream)
            {
                textBox1.Text = sr.ReadLine() + textBox1.ScrollBars;
            }
            */
            sr.Close();

        }
    }
}
