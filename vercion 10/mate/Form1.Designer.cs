namespace c_sahrp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.fbd1 = new System.Windows.Forms.FolderBrowserDialog();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Iniciar_random = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.copiar_dos = new System.Windows.Forms.Button();
            this.copiar_tres = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.buscar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configurarLocalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarLinksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXTRASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectorManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mmmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iMGMovToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label_num_models = new System.Windows.Forms.Label();
            this.label_copiar_img = new System.Windows.Forms.Label();
            this.label_random = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofd1
            // 
            this.ofd1.FileName = "openFileDialog1";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(930, 169);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Carpeta";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(930, 203);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(61, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Archivo";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(465, 410);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(39, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(465, 433);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(39, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(421, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Origen";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 440);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Destino";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(20, 35);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 46);
            this.button4.TabIndex = 9;
            this.button4.Text = "Seleccionar carpeta de destino";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(254, 421);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 32);
            this.button5.TabIndex = 10;
            this.button5.Text = "Copiar  (&1)";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Iniciar_random
            // 
            this.Iniciar_random.Location = new System.Drawing.Point(20, 99);
            this.Iniciar_random.Name = "Iniciar_random";
            this.Iniciar_random.Size = new System.Drawing.Size(118, 87);
            this.Iniciar_random.TabIndex = 11;
            this.Iniciar_random.Text = "Iniciar ramdon   (&A)";
            this.Iniciar_random.UseVisualStyleBackColor = true;
            this.Iniciar_random.Click += new System.EventHandler(this.Iniciar_random_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(757, 35);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(264, 305);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(466, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(266, 305);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(186, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 305);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(862, 377);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 18;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(576, 377);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 17;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(254, 377);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 16;
            // 
            // copiar_dos
            // 
            this.copiar_dos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copiar_dos.Location = new System.Drawing.Point(576, 421);
            this.copiar_dos.Name = "copiar_dos";
            this.copiar_dos.Size = new System.Drawing.Size(100, 32);
            this.copiar_dos.TabIndex = 19;
            this.copiar_dos.Text = "Copiar (&2)";
            this.copiar_dos.UseVisualStyleBackColor = true;
            this.copiar_dos.Click += new System.EventHandler(this.copiar_dos_Click);
            // 
            // copiar_tres
            // 
            this.copiar_tres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copiar_tres.Location = new System.Drawing.Point(862, 421);
            this.copiar_tres.Name = "copiar_tres";
            this.copiar_tres.Size = new System.Drawing.Size(100, 32);
            this.copiar_tres.TabIndex = 20;
            this.copiar_tres.Text = "Copiar (&3)";
            this.copiar_tres.UseVisualStyleBackColor = true;
            this.copiar_tres.Click += new System.EventHandler(this.copiar_tres_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(20, 323);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(61, 17);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "Local 1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(20, 352);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(61, 17);
            this.checkBox2.TabIndex = 23;
            this.checkBox2.Text = "Local 2";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // buscar
            // 
            this.buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar.Location = new System.Drawing.Point(75, 267);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(58, 32);
            this.buscar.TabIndex = 24;
            this.buscar.Text = "&BS";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(20, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 32);
            this.button2.TabIndex = 25;
            this.button2.Text = "<--(&Z)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurarLocalToolStripMenuItem,
            this.selectorManualToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1063, 24);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configurarLocalToolStripMenuItem
            // 
            this.configurarLocalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurarLinksToolStripMenuItem,
            this.eXTRASToolStripMenuItem});
            this.configurarLocalToolStripMenuItem.Name = "configurarLocalToolStripMenuItem";
            this.configurarLocalToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.configurarLocalToolStripMenuItem.Text = "Configurar Local";
            // 
            // configurarLinksToolStripMenuItem
            // 
            this.configurarLinksToolStripMenuItem.Name = "configurarLinksToolStripMenuItem";
            this.configurarLinksToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.configurarLinksToolStripMenuItem.Text = "Configurar links";
            this.configurarLinksToolStripMenuItem.Click += new System.EventHandler(this.configurarLinksToolStripMenuItem_Click);
            // 
            // eXTRASToolStripMenuItem
            // 
            this.eXTRASToolStripMenuItem.Name = "eXTRASToolStripMenuItem";
            this.eXTRASToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.eXTRASToolStripMenuItem.Text = "EXTRAS";
            this.eXTRASToolStripMenuItem.Click += new System.EventHandler(this.eXTRASToolStripMenuItem_Click);
            // 
            // selectorManualToolStripMenuItem
            // 
            this.selectorManualToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.mmmToolStripMenuItem,
            this.iMGMovToolStripMenuItem});
            this.selectorManualToolStripMenuItem.Name = "selectorManualToolStripMenuItem";
            this.selectorManualToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.selectorManualToolStripMenuItem.Text = "Utilidades";
            this.selectorManualToolStripMenuItem.Click += new System.EventHandler(this.selectorManualToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.toolStripMenuItem1.Text = "Mov RAR";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // mmmToolStripMenuItem
            // 
            this.mmmToolStripMenuItem.Name = "mmmToolStripMenuItem";
            this.mmmToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.mmmToolStripMenuItem.Text = "Selector manual";
            this.mmmToolStripMenuItem.Click += new System.EventHandler(this.mmmToolStripMenuItem_Click);
            // 
            // iMGMovToolStripMenuItem
            // 
            this.iMGMovToolStripMenuItem.Name = "iMGMovToolStripMenuItem";
            this.iMGMovToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.iMGMovToolStripMenuItem.Text = "IMG mov";
            this.iMGMovToolStripMenuItem.Click += new System.EventHandler(this.iMGMovToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 499);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Carpeta Destino Actual";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(20, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 32);
            this.button1.TabIndex = 29;
            this.button1.Text = "&Open carpeta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_num_models
            // 
            this.label_num_models.AutoSize = true;
            this.label_num_models.Location = new System.Drawing.Point(9, 410);
            this.label_num_models.Name = "label_num_models";
            this.label_num_models.Size = new System.Drawing.Size(116, 13);
            this.label_num_models.TabIndex = 30;
            this.label_num_models.Text = "Carpeta Destino Actual";
            // 
            // label_copiar_img
            // 
            this.label_copiar_img.AutoSize = true;
            this.label_copiar_img.Location = new System.Drawing.Point(12, 440);
            this.label_copiar_img.Name = "label_copiar_img";
            this.label_copiar_img.Size = new System.Drawing.Size(74, 13);
            this.label_copiar_img.TabIndex = 31;
            this.label_copiar_img.Text = "Copiar imagen";
            // 
            // label_random
            // 
            this.label_random.AutoSize = true;
            this.label_random.Location = new System.Drawing.Point(12, 467);
            this.label_random.Name = "label_random";
            this.label_random.Size = new System.Drawing.Size(79, 13);
            this.label_random.TabIndex = 32;
            this.label_random.Text = "Repetir random";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(942, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 33;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1063, 521);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label_random);
            this.Controls.Add(this.label_copiar_img);
            this.Controls.Add(this.label_num_models);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.copiar_tres);
            this.Controls.Add(this.copiar_dos);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Iniciar_random);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Copiar y mover";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog fbd1;
        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Iniciar_random;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
       
        private System.Windows.Forms.Button copiar_dos;
        private System.Windows.Forms.Button copiar_tres;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configurarLocalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectorManualToolStripMenuItem;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mmmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iMGMovToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurarLinksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXTRASToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label_num_models;
        public System.Windows.Forms.Label label_copiar_img;
        public System.Windows.Forms.Label label_random;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

