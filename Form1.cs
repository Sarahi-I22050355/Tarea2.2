using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Tarea2._2
{
    public partial class Form1 : Form
    {
        Contacto x = new Contacto();
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            x.Nombre= textBox1.Text;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            x.Telefono = textBox2.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            x.FechaNacimiento = DateTime.Parse("2003/01/01");
            //textBox3.Text = x.ToString();
            MessageBox.Show(x.ToString());
        }
        //Solo por si se tenia que hacer sin ventana emergente.
        /*private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }*/
    }
}
