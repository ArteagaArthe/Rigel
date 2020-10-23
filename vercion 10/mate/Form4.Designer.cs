namespace c_sahrp
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
            this.fbd1 = new System.Windows.Forms.FolderBrowserDialog();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.opciones = new System.Windows.Forms.GroupBox();
            this.select_folder = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.opciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // opciones
            // 
            this.opciones.Controls.Add(this.select_folder);
            this.opciones.Controls.Add(this.button1);
            this.opciones.Location = new System.Drawing.Point(47, 57);
            this.opciones.Name = "opciones";
            this.opciones.Size = new System.Drawing.Size(134, 131);
            this.opciones.TabIndex = 23;
            this.opciones.TabStop = false;
            // 
            // select_folder
            // 
            this.select_folder.Location = new System.Drawing.Point(8, 18);
            this.select_folder.Name = "select_folder";
            this.select_folder.Size = new System.Drawing.Size(113, 42);
            this.select_folder.TabIndex = 12;
            this.select_folder.Text = "seleccionar carpeta de imagenes";
            this.select_folder.UseVisualStyleBackColor = true;
            this.select_folder.Click += new System.EventHandler(this.select_folder_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 59);
            this.button1.TabIndex = 6;
            this.button1.Text = "Seleccionar carpeta archivos RAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 252);
            this.Controls.Add(this.opciones);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.opciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog fbd1;
        private System.Windows.Forms.GroupBox opciones;
        private System.Windows.Forms.Button select_folder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

    }
}