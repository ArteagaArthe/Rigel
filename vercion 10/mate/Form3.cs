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


namespace c_sahrp
{
    public partial class Form3 : Form
    {
        string Cm;    // aguardaran  la configuracion actual
        string Ci;
        string Cm2;
        string Ci2;
      string[] Local = System.IO.File.ReadAllLines(@"local.txt");

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           
            textBox1.Text = Local[0];   //configuracion local carpeta de los models
            textBox2.Text = Local[1];   //configuracion local imagenes de los models
            textBox3.Text = Local[2];   //configuracion local carpeta de los models  2
            textBox4.Text = Local[3];   //configuracion local imagenes de los models 2
            textBox5.Text = Local[4];
            
          Cm = Local[0];   //configuracion local carpeta de los models
          Ci = Local[1];   //configuracion local imagenes de los models
          Cm2 =Local[2];   //configuracion local carpeta de los models  2
          Ci2 = Local[3];   //configuracion local imagenes de los models 2
         
        }

        private void button1_Click(object sender, EventArgs e)
        {                                                    //|valor dentro del txt|,|valor nuevo a meter|

            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text))
            { MessageBox.Show("asegurase de llenar todos los texbox"); }
            else
            {
                File.WriteAllText(@"local.txt", File.ReadAllText(@"local.txt").Replace(Cm, textBox1.Text));   // actualiza las direcciones por la que el usuario de 
                File.WriteAllText(@"local.txt", File.ReadAllText(@"local.txt").Replace(Ci, textBox2.Text));
                File.WriteAllText(@"local.txt", File.ReadAllText(@"local.txt").Replace(Cm2, textBox3.Text));
                File.WriteAllText(@"local.txt", File.ReadAllText(@"local.txt").Replace(Ci2, textBox4.Text));
                File.WriteAllText(@"local.txt", File.ReadAllText(@"local.txt").Replace(Local[4], textBox5.Text));
                Form1.actulizo = true; // se actualiza el form1 con las nuevas rutas
                MessageBox.Show("hecho sempai");
                this.Refresh();
                this.Close();
            }
          
            
            
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Form1.actulizo == true) { this.Refresh(); Form1.actulizo = false; Form1.Local = Local = System.IO.File.ReadAllLines(@"local.txt"); Form1.carpeta_dos = Local[4];  } // utilizo para actualizar en el Form1
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
