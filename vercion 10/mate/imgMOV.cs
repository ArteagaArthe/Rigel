using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using System.IO;
namespace c_sahrp
{
    public partial class imgMOV : Form
    {
        FolderBrowserDialog fbd1 = new FolderBrowserDialog();
        Computer mycomputer = new Computer(); // Así accederemos al "FileSystem".
        string Ruta_busqueda;
        string Ruta_mover;
        string[] ubicacion;
        string[] ubicacion2;
        string diago = "\\";
       
        public imgMOV()
        {
            InitializeComponent();
        }

        private void imgMOV_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var resultado = fbd1.ShowDialog();
            if (resultado == DialogResult.OK) { Ruta_busqueda = fbd1.SelectedPath; }
            ubicacion = Directory.GetFiles(Ruta_busqueda);
            Ruta_busqueda = Ruta_busqueda + diago;
            label_busqueda.Text = Ruta_busqueda;
            MessageBox.Show(Ruta_busqueda);
            //for (int i = 0; i < ubicacion.Length; i++) { MessageBox.Show(ubicacion[i]); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var resultado = fbd1.ShowDialog();
            if (resultado == DialogResult.OK) { Ruta_mover = fbd1.SelectedPath; }  //selecion de la capeta a mover a los archivos
        
            Ruta_mover = Ruta_mover + diago;
            label_mover.Text = Ruta_mover;
            MessageBox.Show(Ruta_mover);
        }

        private void button3_Click(object sender, EventArgs e)
        {


            ubicacion2 = Directory.GetFiles(Ruta_busqueda, "*" + clave.Text + "*.*"); // busca nombres archivos por medio de la palabra clave
           
            for (int i = 0; i < ubicacion2.Length; i++)
            {
                try
                {
                    mycomputer.FileSystem.MoveFile(Ruta_busqueda + "\\" + (Path.GetFileName(ubicacion2[i])), Ruta_mover + "\\" + (Path.GetFileName(ubicacion2[i])));
                }
                catch { };
            }
            MessageBox.Show("Hecho sempai");
        }

     
    }
}
