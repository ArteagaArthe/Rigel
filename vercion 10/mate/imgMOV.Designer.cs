namespace c_sahrp
{
    partial class imgMOV
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
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.clave = new System.Windows.Forms.TextBox();
            this.label_busqueda = new System.Windows.Forms.Label();
            this.label_mover = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Selecciona carpeta busqueda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "Carpeta a mover";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(130, 204);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Ejecutar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // clave
            // 
            this.clave.AllowDrop = true;
            this.clave.Location = new System.Drawing.Point(24, 206);
            this.clave.Name = "clave";
            this.clave.Size = new System.Drawing.Size(100, 20);
            this.clave.TabIndex = 3;
            // 
            // label_busqueda
            // 
            this.label_busqueda.AutoSize = true;
            this.label_busqueda.Location = new System.Drawing.Point(210, 74);
            this.label_busqueda.Name = "label_busqueda";
            this.label_busqueda.Size = new System.Drawing.Size(0, 13);
            this.label_busqueda.TabIndex = 4;
            // 
            // label_mover
            // 
            this.label_mover.AutoSize = true;
            this.label_mover.Location = new System.Drawing.Point(210, 116);
            this.label_mover.Name = "label_mover";
            this.label_mover.Size = new System.Drawing.Size(0, 13);
            this.label_mover.TabIndex = 5;
            // 
            // imgMOV
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(507, 331);
            this.Controls.Add(this.label_mover);
            this.Controls.Add(this.label_busqueda);
            this.Controls.Add(this.clave);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "imgMOV";
            this.Text = "imgMOV";
            this.Load += new System.EventHandler(this.imgMOV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox clave;
        private System.Windows.Forms.Label label_busqueda;
        private System.Windows.Forms.Label label_mover;
    }
}