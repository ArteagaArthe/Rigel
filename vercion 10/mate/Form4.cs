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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void select_folder_Click(object sender, EventArgs e)
        {

            openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                Form1.ubicacion = Directory.GetFiles(Path.GetDirectoryName(openFileDialog1.FileName)).ToList();  //Mete todas las direcciones de imagenes a un arreglo
            Form1.ubicacion_de_imagenes = Path.GetDirectoryName(Form1.ubicacion[0]) + Form1.diago;
            MessageBox.Show(openFileDialog1.FileName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd1 = new FolderBrowserDialog();
            // El siguiente código servirá para que si hacemos un click en Ok con el selector de carpeta, el texto del TextBox1 sea la ruta seleccionada.
            var resultado = fbd1.ShowDialog();

            if (resultado == DialogResult.OK) { Form1.carpeta = fbd1.SelectedPath; }
            MessageBox.Show(Form1.carpeta);
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
