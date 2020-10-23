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
    public partial class Form2 : Form
    {
     
        int gato = 0; // nos ayuda a dar a la sieguiente imagen ya que no es necesario hacer random
        Configuraciones config = new Configuraciones();
       
    
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
    

            pictureBox1.Image = Image.FromFile(Form1.ubicacion[gato]); //image box al azar}
            nom.Text = Path.GetFileNameWithoutExtension(Form1.ubicacion[gato]);
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FullScreenImage(((PictureBox)sender).Image);
        }
        private void FullScreenImage(Image imageToShow)
        {
            Form fullScreenForm = new Form()
            {
                WindowState = FormWindowState.Maximized,
                FormBorderStyle = FormBorderStyle.None,
                BackgroundImage = imageToShow,
                BackgroundImageLayout = ImageLayout.Zoom
            };

            fullScreenForm.Click += fullScreen_Click;

            fullScreenForm.ShowDialog();
        }            //metodo para hacer grande una imagen de un picture box

        private void fullScreen_Click(object sender, EventArgs e)
        {
            ((Form)sender).Close();
        }   // cierra el form
        private void pictureBox1_DoubleClick(object sender, EventArgs e)  // cierra el form
        {
            FullScreenImage(((PictureBox)sender).Image);  //llama al metodo  fullscreem para mostrar la imagen clickead en toda la pantalla
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    nom.Text = Path.GetFileNameWithoutExtension(Form1.ubicacion[gato]);
                    pictureBox1.Image = Image.FromFile(Form1.ubicacion[gato]);
                } //image box al azar}}
                gato = gato + 1;
            }
            catch { }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (gato > 0)
            {
                gato = gato - 1;
                pictureBox1.Image = Image.FromFile(Form1.ubicacion[gato]); //image box al azar}
                nom.Text = Path.GetFileNameWithoutExtension(Form1.ubicacion[gato]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Form1.TF == true)
            {
                gato = 0;
                Form1.ubicacion = Directory.GetFiles(Form1.Local[1], "*" + clave.Text + "*.*").Union(Form1.ubicacion = Directory.GetFiles(Form1.Local[3], "*" + clave.Text + "*.*").ToList()).ToList(); // busca nombres archivos por medio de la palabra clave
                nom.Text = Path.GetFileNameWithoutExtension(Form1.ubicacion[gato]);
                resul.Text = "Encontrados " + Convert.ToString(Form1.ubicacion.Count); //etiqueta
            }
            else
            {
                try
                {
                    gato = 0;
                   Form1.ubicacion = Directory.GetFiles(Form1.ubicacion_de_imagenes, "*" + clave.Text + "*.*").ToList(); // busca nombres archivos por medio de la palabra clave
                    pictureBox1.Image = Image.FromFile(Form1.ubicacion[gato]); //image box 
                    nom.Text = Path.GetFileNameWithoutExtension(Form1.ubicacion[gato]);
                    resul.Text = "Encontrados " + Convert.ToString(Form1.ubicacion.Count); //etiqueta
                }
                catch
                {
                    MessageBox.Show("cero elementos encontrados");
              
                    resul.Text = "Encontrados 0";
                }

            }
        }

        private void copiar_tres_Click(object sender, EventArgs e)
        {
            

            //if (Form1.TF == true)
            //{
                config.mover_archivo(nom.Text);
                config.mover_imagenes(nom.Text);
            //}
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FullScreenImage(((PictureBox)sender).Image);
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }

        

      

       

   

      
       
    }
}
