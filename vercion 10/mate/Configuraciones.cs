using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualBasic.Devices; // Recuerden agregar la referencia "Microsoft.VisualBasic".

namespace c_sahrp
{
    class Configuraciones
    {
        public static Computer mycomputer = new Computer(); // Así accederemos al "FileSystem".
        string cadena;
        string cadena2;
        string[] ubicacion;
        public void mover_imagenes(string a)
        {
            string pathString2 = Form1.Local[4] + "\\IMG";
            if (Form1.Local[6] == "img_true")
            {
                if (System.IO.File.Exists(Form1.Local[1] + Form1.diago + a + Form1.jpg))
                {
                    Directory.CreateDirectory(pathString2);
                    cadena = Form1.Local[1] + Form1.diago + a + Form1.jpg;
                    cadena2 = pathString2 + Form1.diago + a + Form1.jpg;
                    mycomputer.FileSystem.CopyFile(cadena, cadena2);
                }
                else
                {
                    if (System.IO.File.Exists(Form1.Local[3] + Form1.diago + a + Form1.jpg))
                    {
                        Directory.CreateDirectory(pathString2); 
                        cadena = Form1.Local[3] + Form1.diago + a + Form1.jpg;
                        cadena2 = pathString2 + Form1.diago + a + Form1.jpg;
                        mycomputer.FileSystem.CopyFile(cadena, cadena2);
                    }
                }


                if (System.IO.File.Exists(Form1.Local[1] + Form1.diago + a + Form1.png))
                {
                    Directory.CreateDirectory(pathString2);
                    cadena = Form1.Local[1] + Form1.diago + a + Form1.png;
                    cadena2 = pathString2 + Form1.diago + a + Form1.png;
                    mycomputer.FileSystem.CopyFile(cadena, cadena2);
                }
                else
                {
                    if (System.IO.File.Exists(Form1.Local[3] + Form1.diago + a + Form1.png))
                    {
                        Directory.CreateDirectory(pathString2);
                        cadena = Form1.Local[3] + Form1.diago + a + Form1.png;
                        cadena2 = pathString2 + Form1.diago + a + Form1.png;
                        mycomputer.FileSystem.CopyFile(cadena, cadena2);
                    }
                }

                if (System.IO.File.Exists(Form1.Local[1] + Form1.diago + a + Form1.bmp))
                {
                    Directory.CreateDirectory(pathString2);
                    cadena = Form1.Local[1] + Form1.diago + a + Form1.bmp;
                    cadena2 = pathString2 + Form1.diago + a + Form1.bmp;
                    mycomputer.FileSystem.CopyFile(cadena, cadena2);
                }
                else
                {
                    if (System.IO.File.Exists(Form1.Local[3] + Form1.diago + a + Form1.bmp))
                    {
                        Directory.CreateDirectory(pathString2);
                        cadena = Form1.Local[3] + Form1.diago + a + Form1.bmp;
                        cadena2 = pathString2 + Form1.diago + a + Form1.bmp;
                        mycomputer.FileSystem.CopyFile(cadena, cadena2);
                    }
                }

            }
        }
        public void mover_archivo(string nom)
        {
             if (System.IO.File.Exists(Form1.carpetas_ambas[0] + Form1.diago + nom+ Form1.R))
                {


                    cadena = Form1.carpetas_ambas[0] + Form1.diago + nom + Form1.R;
                    cadena2 = Form1.carpeta_dos + Form1.diago + nom + Form1.R;
                    Form1.mycomputer.FileSystem.CopyFile(cadena, cadena2);
                 

                }
                else
                {

                    if (System.IO.File.Exists(Form1.carpetas_ambas[1] + Form1.diago + nom + Form1.R))
                    {
                     cadena = Form1.carpetas_ambas[1] + Form1.diago + nom + Form1.R;
                     cadena2= Form1.carpeta_dos + Form1.diago + nom + Form1.R;
                        Form1.mycomputer.FileSystem.CopyFile(cadena, cadena2);
                       
                    }
                }

                if (System.IO.File.Exists(Form1.carpetas_ambas[0] + Form1.diago + nom + Form1.z))
                {
                    cadena = Form1.carpetas_ambas[0] + Form1.diago + nom+ Form1.z;
                    cadena2 = Form1.carpeta_dos + Form1.diago + nom + Form1.z;
                    Form1.mycomputer.FileSystem.CopyFile(cadena, cadena2);
           

                }
                else
                {
                    if (System.IO.File.Exists(Form1.carpetas_ambas[1] + Form1.diago + nom+ Form1.z))
                    {
                        cadena = Form1.carpetas_ambas[1] + Form1.diago + nom + Form1.z;
                        cadena2= Form1.carpeta_dos + Form1.diago + nom + Form1.z;
                        Form1.mycomputer.FileSystem.CopyFile(cadena, cadena2);
                       

                    }
                }
                if (System.IO.File.Exists(Form1.carpetas_ambas[0] + Form1.diago + nom + Form1.zdef))
                {
                    cadena = Form1.carpetas_ambas[0] + Form1.diago + nom + Form1.zdef;
                    cadena2 = Form1.carpeta_dos + Form1.diago + nom + Form1.zdef;
                    Form1.mycomputer.FileSystem.CopyFile(cadena, cadena2);
                    
                }
                else
                {
                    if (System.IO.File.Exists(Form1.carpetas_ambas[1] + Form1.diago + nom + Form1.zdef))
                    {
                        cadena = Form1.carpetas_ambas[1] + Form1.diago + nom + Form1.zdef;
                        cadena2 = Form1.carpeta_dos + Form1.diago + nom + Form1.zdef;
                        Form1.mycomputer.FileSystem.CopyFile(cadena, cadena2);
                      
                    }
                    //else
                    //{
                    //    if (System.IO.File.Exists(Form1.carpeta + Form1.diago + nom + Form1.R))
                    //    {

                    //        cadena = Form1.carpeta + Form1.diago + nom + Form1.R;
                    //        cadena2 = Form1.carpeta_dos + Form1.diago + nom + Form1.R;
                    //        Form1.mycomputer.FileSystem.CopyFile(cadena, cadena2);
                    //        //textBox1.Clear();
                    //        //textBox2.Clear();

                    //    }
                    //    if (System.IO.File.Exists(Form1.carpeta + Form1.diago + nom + Form1.z))
                    //    {

                    //        cadena = Form1.carpeta + Form1.diago + nom + Form1.z;
                    //        cadena2 = Form1.carpeta_dos + Form1.diago + nom + Form1.z;
                    //        Form1.mycomputer.FileSystem.CopyFile(cadena, cadena2);
                    //        //textBox1.Clear();
                    //        //textBox2.Clear();

                    //    }
                    //    if (System.IO.File.Exists(Form1.carpeta + Form1.diago + nom + Form1.zdef))
                    //    {

                    //        cadena = Form1.carpeta + Form1.diago + nom + Form1.zdef;
                    //        cadena2 = Form1.carpeta_dos + Form1.diago + nom + Form1.zdef;
                    //        Form1.mycomputer.FileSystem.CopyFile(cadena, cadena2);
                    //        //textBox1.Clear();
                    //        //textBox2.Clear();

                    //    }
                    //}
                }
             }
        public string[] Ruta_IM_1()
        {
            ubicacion = Directory.GetFiles(Path.GetDirectoryName(Form1.Local[1])); //RUTA DE IMAGENES
            return ubicacion;
        }
        public string[] Ruta_IM_2()
        {
            ubicacion = Directory.GetFiles(Path.GetDirectoryName(Form1.Local[3])); //RUTA DE IMAGENES
            return ubicacion;
        }
        public string[] Ruta_IM_Ambas()
        {
            ubicacion = Directory.GetFiles(Path.GetDirectoryName(Form1.Local[1])).Union(ubicacion = Directory.GetFiles(Path.GetDirectoryName(Form1.Local[3]))).ToArray();
            return ubicacion;
        }
       
           
    }
}
