using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices; // Recuerden agregar la referencia "Microsoft.VisualBas
using System.Linq;

namespace c_sahrp
{
    public partial class Form1 : Form
    {
      public static  Computer mycomputer = new Computer(); // Así accederemos al "FileSystem".
      Configuraciones confic = new Configuraciones();
      public static List<string> ubicacion = new List<string>();
             Random rnd = new Random();
        int r1, r2, r3;
        //public static string[] ubicacion; //de las imagenes
         List<string> atras = new List<string>();  // variable para dar hacia atras en caso de querer devolver   
        public static List<string> carpetas_ambas = new List<string>();// contiene las rutas de modelos de ambos locales
         int atras_contador; //variable para efectuar un perfecto atras
         public static string ubicacion_de_imagenes;
        public static  string R = ".rar";
        public static string z = ".zip";
        public static string zdef = ".7z";
        public static string diago = "\\";
        public static string png = ".png";
        public static string jpg = ".jpg";
        public static string bmp = ".bmp";
         public static string carpeta;
         public static string carpeta_dos; // variables de carpeta de destino
         public static bool actulizo = false;
         public static bool TF = false;
         public static string etiqueta;
         int contador_atras;
        
         public static string[] Local = System.IO.File.ReadAllLines(@"local.txt");
      
         public string Filter { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

      
      

        private void button4_Click(object sender, EventArgs e)
        {
            // El siguiente código servirá para que el texto del textbox2 sea igual a la ruta seleccionada + desde el último índice de "\", para copiar el nombre de la carpeta.
            var resultado = fbd1.ShowDialog();
            if (resultado == DialogResult.OK) { carpeta_dos = fbd1.SelectedPath; }
            File.WriteAllText(@"local.txt", File.ReadAllText(@"local.txt").Replace(Local[4], carpeta_dos));
            Local = Local = System.IO.File.ReadAllLines(@"local.txt");
            label4.Text = "Carpeta Destino Actual   " + Local[4] + "";
            MessageBox.Show(carpeta_dos);
         
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // El siguiente código servirá para que si hacemos un click en Ok con el selector de archivos, el texto del TextBox1 sea el archivo seleccionado.
            var resultado = ofd1.ShowDialog();
            if (resultado == DialogResult.OK) { textBox1.Text = ofd1.FileName; }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            confic.mover_archivo(textBox5.Text);
            confic.mover_imagenes(textBox5.Text);
              
        }
        public  void archivo(string nombre)
        {
             if (System.IO.File.Exists(carpeta + diago + nombre + R))
            {

                textBox1.Text = carpeta + diago + nombre + R;
                textBox2.Text = carpeta_dos + diago + nombre + R;
                mycomputer.FileSystem.CopyFile(textBox1.Text, textBox2.Text);
                textBox1.Clear();
                textBox2.Clear();

            }

            if (System.IO.File.Exists(carpeta + diago + nombre + z))
            {
                textBox1.Text = carpeta + diago + nombre + z;
                textBox2.Text = carpeta_dos + diago + nombre + z;
                mycomputer.FileSystem.CopyFile(textBox1.Text, textBox2.Text);
                textBox1.Clear();
                textBox2.Clear();

            }
            if (System.IO.File.Exists(carpeta + diago +nombre + zdef))
            {
                textBox1.Text = carpeta + diago + nombre + zdef;
                textBox2.Text = carpeta_dos + diago + nombre + zdef;
                mycomputer.FileSystem.CopyFile(textBox1.Text, textBox2.Text);
                textBox1.Clear();
                textBox2.Clear();
            }
        }// metoddo para mover los archivos rar a la carpeta deseada
      
      

        private void button3_Click(object sender, EventArgs e)
        {
            //if (tipo == "carpeta") { mycomputer.FileSystem.MoveDirectory(textBox1.Text, textBox2.Text); } // Movemos la carpeta.
            //if (tipo == "archivo") { mycomputer.FileSystem.MoveFile(textBox1.Text, textBox2.Text); } // Movemos el archivo.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carpetas_ambas.Add(Local[0]);
            carpetas_ambas.Add(Local[2]);
            carpeta_dos = Local[4];
            checkBox1.Checked = true;
            label4.Text = "Carpeta Destino Actual   "+Local[4]+"";
            label_copiar_img.Text = "Copiar imagen " + Local[6] + "";
            label_random.Text = "Random " + Local[7] + "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       

        private void Iniciar_random_Click(object sender, EventArgs e)
        {
           // if (actulizo == true) { this.Refresh(); actulizo = false; Local = Local = System.IO.File.ReadAllLines(@"local.txt"); carpeta_dos = Local[4]; }
            atras_contador = 0;
            label4.Text = "Carpeta Destino Actual   " + Local[4] + "";
           

            //if (checkBox1.Checked == true && checkBox2.Checked == false)
            //{
            //    carpeta = Local[0];//UBICACION DE LOS ARCHIVOS RAR
            //    ubicacion = Directory.GetFiles(Path.GetDirectoryName(Local[1])); //RUTA DE IMAGENES
            //    ubicacion_de_imagenes = Path.GetDirectoryName(ubicacion[0]) + diago;


            //}
            //if (checkBox2.Checked == true && checkBox1.Checked == false)
            //{
            //    carpeta = Local[2];//UBICACION DE LOS ARCHIVOS RAR
            //    ubicacion = Directory.GetFiles(Path.GetDirectoryName(Local[3])); //RUTA DE IMAGENES
            //    ubicacion_de_imagenes = Path.GetDirectoryName(ubicacion[0]) + diago;
            //}
            //if (checkBox1.Checked == true && checkBox2.Checked == true)
            //{

            //    ubicacion = Directory.GetFiles(Path.GetDirectoryName(Local[1])).Union(ubicacion = Directory.GetFiles(Path.GetDirectoryName(Local[3]))).ToArray();
            //}






            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
            } 
                r1 = rnd.Next(0, ubicacion.Count); atras.Add(ubicacion[r1]);
                pictureBox1.Image = Image.FromFile(ubicacion[r1]); //image box al azar}
                textBox5.Text = Path.GetFileNameWithoutExtension(ubicacion[r1]);// tex box al azar NOMBRE
                string a = Path.GetFullPath(ubicacion[r1]);
                ubicacion.RemoveAt(r1);


                if (pictureBox2.Image != null)
                {
                    pictureBox2.Image.Dispose();
                } 

                r2 = rnd.Next(0, ubicacion.Count); atras.Add(ubicacion[r2]);
                string b = Path.GetFullPath(ubicacion[r2]);
                pictureBox2.Image = Image.FromFile(ubicacion[r2]);
                textBox4.Text = Path.GetFileNameWithoutExtension(ubicacion[r2]);
                ubicacion.RemoveAt(r2);

                if (pictureBox3.Image != null)
                {
                    pictureBox3.Image.Dispose();
                } 

                r3 = rnd.Next(0, ubicacion.Count); atras.Add(ubicacion[r3]);//CREACION DEL RANDOM EN LA LISTA CON LAS UBICACIONES DE LAS IMAGENES 
                string c = Path.GetFullPath(ubicacion[r3]);
                pictureBox3.Image = Image.FromFile(ubicacion[r3]);
                textBox3.Text = Path.GetFileNameWithoutExtension(ubicacion[r3]);
                ubicacion.RemoveAt(r3);

           
              
               
                //if (ubicacion.Contains(b))    codigo ling que nos dice si el elemento b esta en la lista hara algo
                //{
                //    MessageBox.Show("no se elimino x(  C");
                //}
           

                label_num_models.Text = "Numero de Modelos " + Convert.ToString(ubicacion.Count);
                textBox1.Text = carpeta + diago + textBox5.Text;
                contador_atras++;
                if (contador_atras > 5)
                {
                    atras.RemoveRange(0,5);
                    contador_atras = 0;
             
                }
            

            }
            
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FullScreenImage(((PictureBox)sender).Image);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FullScreenImage(((PictureBox)sender).Image);
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

        private void copiar_dos_Click(object sender, EventArgs e)
        {
            confic.mover_archivo(textBox4.Text);
            confic.mover_imagenes(textBox4.Text);
        }

        private void copiar_tres_Click(object sender, EventArgs e)
        {
            confic.mover_archivo(textBox3.Text);
            confic.mover_imagenes(textBox3.Text);
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox2.Checked)
            {
                TF = true;
            }
            else
            {
                TF = false;
            }
            Form2 a = new Form2();
            a.Show();

            //string[] archivos = Directory.GetFiles("A:\\MEGAsync\\Documentos\\MODELOS MMD\\otros\\IMAGENES DE LOS MODELS\\", "*miku*.*");
            //foreach (string archivo in archivos)
            //{
            // MessageBox.Show(archivo);
            //}
        
        //     try 
        //{
        //    // Only get files that begin with the letter "c".
        //    string[] dirs = Directory.GetFiles(@"A:\\MEGAsync\\Documentos\\MODELOS MMD\\otros\\IMAGENES DE LOS MODELS\\", "*.png");
        //   MessageBox.Show(Convert.ToString(dirs.Length));
           
        //}
        //     catch 
        //     {
        //         MessageBox.Show("The process failed: {0}", e.ToString());
        //     }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            atras_contador = atras_contador - 1;

            r3 = atras.Count - 3 + atras_contador;
            r2 = atras.Count - 4 + atras_contador;
            r1 = atras.Count - 5 + atras_contador;

            pictureBox1.Image = Image.FromFile(atras[r1]); //image box al azar}
            pictureBox2.Image = Image.FromFile(atras[r2]);
            pictureBox3.Image = Image.FromFile(atras[r3]);

            textBox5.Text = Path.GetFileNameWithoutExtension(atras[r1]);// tex box al azar NOMBRE
            textBox4.Text = Path.GetFileNameWithoutExtension(atras[r2]);
            textBox3.Text = Path.GetFileNameWithoutExtension(atras[r3]);
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            buscar.PerformClick();
        }

       

        private void selectorManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
   
        }

        private void mmmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 a = new Form4();
            a.Show();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form5 a = new Form5();

            a.Show();
        }

        private void iMGMovToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imgMOV a = new imgMOV();
            a.Show();
        }

        private void configurarLinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 a = new Form3();
            a.Show();
        }

        private void eXTRASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EXTRAS a = new EXTRAS();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Local[4]);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && checkBox2.Checked == false)
            {
                carpeta = Local[0];//UBICACION DE LOS ARCHIVOS RAR
                ubicacion =   Directory.GetFiles(Path.GetDirectoryName(Local[1])).ToList(); //RUTA DE IMAGENES
                ubicacion_de_imagenes = Path.GetDirectoryName(ubicacion[0]) + diago;
                label_num_models.Text = "Numero de Modelos " + Convert.ToString(ubicacion.Count);


            }
            if (checkBox1.Checked == true && checkBox2.Checked == true)
            { ubicacion = Directory.GetFiles(Path.GetDirectoryName(Local[1])).ToList().Union(ubicacion = Directory.GetFiles(Path.GetDirectoryName(Local[3])).ToList()).ToList();
            label_num_models.Text = "Numero de Modelos " + Convert.ToString(ubicacion.Count);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true && checkBox1.Checked == false)
            {
                carpeta = Local[2];//UBICACION DE LOS ARCHIVOS RAR
                ubicacion = Directory.GetFiles(Path.GetDirectoryName(Local[3])).ToList(); //RUTA DE IMAGENES
                ubicacion_de_imagenes = Path.GetDirectoryName(ubicacion[0]) + diago;
                label_num_models.Text = "Numero de Modelos " + Convert.ToString(ubicacion.Count);
            }
            if (checkBox1.Checked == true && checkBox2.Checked == true)
            {
                ubicacion = Directory.GetFiles(Path.GetDirectoryName(Local[1])).Union(ubicacion = Directory.GetFiles(Path.GetDirectoryName(Local[3])).ToList()).ToList();
            label_num_models.Text = "Numero de Modelos " + Convert.ToString(ubicacion.Count);
            }
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            Visualizer a = new Visualizer();
            a.Show();
        }

  

        //private void checkBox1_CheckedChanged(object sender, EventArgs e)
        //{
          
        //  if (checkBox2.Checked == true) { ubicacion = confic.Ruta_IM_Ambas(); }
        //  else { ubicacion = confic.Ruta_IM_1(); }
        //}

        //private void checkBox2_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (checkBox1.Checked == true) { ubicacion = confic.Ruta_IM_Ambas(); }
        //    else { ubicacion = confic.Ruta_IM_2(); }
        //}

       
        // Para copiar:
        // mycomputer.FileSystem.CopyDirectory / CopyFile(ruta 1 as string, ruta 2 as string);
        //
        // Para mover:
        // mycomputer.FileSystem.MoveDirectory / MoveFile(ruta 1 as string, ruta 2 as string);
    }
}


