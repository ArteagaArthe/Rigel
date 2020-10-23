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
    public partial class Visualizer : Form
    {
        public Visualizer()
        {
            InitializeComponent();
        }
        int pru = 12;
        int x = 15;
        int y = 89;
      string [,] matriz_de_imagenes = new string[5,5];
        



        private void Visualizer_Load(object sender, EventArgs e)
            {
                for (int filas = 0; filas < matriz_de_imagenes.GetLength(0); filas++)
                {
                    x = 15;
                    y = y + 160;
                    for (int col = 0; col < matriz_de_imagenes.GetLength(1); col++)
                    {
                        //matriz_de_imagenes[filas, col] = "comer";
                        var imgPictureBox = new PictureBox();
                        imgPictureBox.Location = new System.Drawing.Point(x, y);
                        imgPictureBox.Size = new System.Drawing.Size(140, 140);
                        imgPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        imgPictureBox.Image = Image.FromFile(Form1.ubicacion[pru]);
                        
                       
                        Controls.Add(imgPictureBox);
           
                        imgPictureBox.Visible = true;
                    
                        x = x + 160;



                        pru++;
                    }
                   
                }
        }

        private void Visualizer_MouseClick(object sender, MouseEventArgs e)
        {
         
        }
        public string ImageLocation { get; set; }
       
    }
}
