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
    public partial class Form5 : Form
    {
        FolderBrowserDialog fbd1 = new FolderBrowserDialog();
        Computer mycomputer = new Computer(); // Así accederemos al "FileSystem".
        string Ruta_busqueda;
        string Ruta_mover;
        string[] ubicacion;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            //string[] dirs = Directory.GetFiles(@"A:\\MEGAsync\\Documentos\\MODELOS MMD\\otros\\IMAGENES DE LOS MODELS\\", "*.png"); //borrar
            //.Union(ubicacion = Directory.GetFiles(Path.GetDirectoryName(Local[3]))).ToArray();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            var resultado = fbd1.ShowDialog();
            if (resultado == DialogResult.OK) { Ruta_busqueda = fbd1.SelectedPath; }
            MessageBox.Show(Ruta_busqueda);
           
            ubicacion = Directory.GetFiles(Ruta_busqueda,"*.rar").Union(ubicacion = Directory.GetFiles(Ruta_busqueda,"*.zip")).Union(ubicacion = Directory.GetFiles(Ruta_busqueda,"*.7z")).ToArray();
          
            //for (int i = 0; i < ubicacion.Length; i++) { MessageBox.Show(Path.GetFileName(ubicacion[i])); }
            //////for (int i = 0; i < ubicacion.Length; i++) { MessageBox.Show(ubicacion[i]); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var resultado = fbd1.ShowDialog();
            if (resultado == DialogResult.OK) { Ruta_mover = fbd1.SelectedPath; }  //selecion de la capeta a mover a los archivos
            //for (int i = 0; i < ubicacion.Length; i++) { MessageBox.Show(Path.GetFileName(ubicacion[i])); }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {// ciclo que hace que se mueven los archivos
         
                for (int i = 0; i < ubicacion.Length; i++)
                {
                    if (System.IO.File.Exists(Ruta_mover + "\\" + (Path.GetFileName(ubicacion[i]))))
                    {

                        MessageBox.Show("archivo reetido sempai owo");

                    }
                    else { mycomputer.FileSystem.MoveFile(Ruta_busqueda + "\\" + (Path.GetFileName(ubicacion[i])), Ruta_mover + "\\" + (Path.GetFileName(ubicacion[i]))); }
                }
           
            MessageBox.Show("Hecho sempai");
        }
    }
}
