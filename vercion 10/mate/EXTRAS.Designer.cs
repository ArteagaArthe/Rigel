namespace c_sahrp
{
    partial class EXTRAS
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
            this.mov_img = new System.Windows.Forms.CheckBox();
            this.mov_copiar = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mov_img
            // 
            this.mov_img.AutoSize = true;
            this.mov_img.Location = new System.Drawing.Point(30, 52);
            this.mov_img.Name = "mov_img";
            this.mov_img.Size = new System.Drawing.Size(114, 17);
            this.mov_img.TabIndex = 0;
            this.mov_img.Text = "Mover con imagen";
            this.mov_img.UseVisualStyleBackColor = true;
            // 
            // mov_copiar
            // 
            this.mov_copiar.AutoSize = true;
            this.mov_copiar.Location = new System.Drawing.Point(30, 89);
            this.mov_copiar.Name = "mov_copiar";
            this.mov_copiar.Size = new System.Drawing.Size(135, 17);
            this.mov_copiar.TabIndex = 1;
            this.mov_copiar.Text = "Añadir a Lista de Texto";
            this.mov_copiar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(211, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(211, 86);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(109, 20);
            this.textBox2.TabIndex = 4;
            // 
            // EXTRAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 224);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mov_copiar);
            this.Controls.Add(this.mov_img);
            this.Name = "EXTRAS";
            this.Text = "EXTRAS";
            this.Load += new System.EventHandler(this.EXTRAS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox mov_img;
        private System.Windows.Forms.CheckBox mov_copiar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}