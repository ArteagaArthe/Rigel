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
    public partial class EXTRAS : Form
    {
        public EXTRAS()
        {
            InitializeComponent();
        }
        //string[] Extras_config = System.IO.File.ReadAllLines(@"Extras_config.txt");
        //string[] Extras_config2 = System.IO.File.ReadAllLines(@"Extras_config2.txt");
        //string img;
        //string tex;

        private void EXTRAS_Load(object sender, EventArgs e)
        {
            Form1.Local = Form1.Local = System.IO.File.ReadAllLines(@"Local.txt");
            textBox1.Text = Form1.Local[6];
            textBox2.Text = Form1.Local[7];
        
            if (textBox1.Text == "img_true") 
          { mov_img.Checked = true;}
            else { mov_img.Checked = false; }

            if (textBox2.Text == "Repetir_true")
            { mov_copiar.Checked = true; }
            else { mov_copiar.Checked = false; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          Form1.Local =  Form1.Local = System.IO.File.ReadAllLines(@"Local.txt");
            if (mov_img.Checked == true)
            {
               textBox1.Text = "img_true";
               File.WriteAllText(@"Local.txt", File.ReadAllText(@"Local.txt").Replace(Form1.Local[6], textBox1.Text));
               Form1.Local = Form1.Local = System.IO.File.ReadAllLines(@"Local.txt");
               
               this.Refresh();
            }
            else
            {
                textBox1.Text = "img_false";
                File.WriteAllText(@"Local.txt",File.ReadAllText(@"Local.txt").Replace(Form1.Local[6],textBox1.Text));
                Form1.Local = Form1.Local = System.IO.File.ReadAllLines(@"Local.txt");
                this.Refresh();
            }


            if (mov_copiar.Checked == true)
            {
                textBox2.Text = "Repetir_true";
                File.WriteAllText(@"Local.txt", File.ReadAllText(@"Local.txt").Replace(Form1.Local[7], textBox2.Text));
                Form1.Local = Form1.Local = System.IO.File.ReadAllLines(@"Local.txt");
                this.Refresh();
            }
            else
            {
                textBox2.Text = "Repetir_false";
                File.WriteAllText(@"Local.txt", File.ReadAllText(@"Local.txt").Replace(Form1.Local[7], textBox2.Text));
                Form1.Local = Form1.Local = System.IO.File.ReadAllLines(@"Local.txt");
                this.Refresh();
            }
           
            this.Close();
        }

      

        

       
    }
}

