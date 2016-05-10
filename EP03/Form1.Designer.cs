namespace EP03
{
    partial class Form1
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
            this.Controlar = new System.Windows.Forms.Button();
            this.Pausar = new System.Windows.Forms.Button();
            this.Reiniciar = new System.Windows.Forms.Button();
            this.Liberar = new System.Windows.Forms.Button();
            this.InicProc = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Controlar
            // 
            this.Controlar.Location = new System.Drawing.Point(51, 90);
            this.Controlar.Name = "Controlar";
            this.Controlar.Size = new System.Drawing.Size(172, 23);
            this.Controlar.TabIndex = 2;
            this.Controlar.Text = "Controlar Trem";
            this.Controlar.UseVisualStyleBackColor = true;
            this.Controlar.Click += new System.EventHandler(this.Iniciar_Click);
            // 
            // Pausar
            // 
            this.Pausar.Location = new System.Drawing.Point(51, 177);
            this.Pausar.Name = "Pausar";
            this.Pausar.Size = new System.Drawing.Size(172, 23);
            this.Pausar.TabIndex = 4;
            this.Pausar.Text = "Pausar Movimento";
            this.Pausar.UseVisualStyleBackColor = true;
            this.Pausar.Click += new System.EventHandler(this.Pausar_Click);
            // 
            // Reiniciar
            // 
            this.Reiniciar.Location = new System.Drawing.Point(51, 133);
            this.Reiniciar.Name = "Reiniciar";
            this.Reiniciar.Size = new System.Drawing.Size(172, 23);
            this.Reiniciar.TabIndex = 3;
            this.Reiniciar.Text = "Reiniciar Movimento";
            this.Reiniciar.UseVisualStyleBackColor = true;
            this.Reiniciar.Click += new System.EventHandler(this.Reiniciar_Click);
            // 
            // Liberar
            // 
            this.Liberar.Location = new System.Drawing.Point(51, 219);
            this.Liberar.Name = "Liberar";
            this.Liberar.Size = new System.Drawing.Size(172, 23);
            this.Liberar.TabIndex = 5;
            this.Liberar.Text = "Liberar Controle";
            this.Liberar.UseVisualStyleBackColor = true;
            this.Liberar.Click += new System.EventHandler(this.Liberar_Click);
            // 
            // InicProc
            // 
            this.InicProc.Location = new System.Drawing.Point(197, 30);
            this.InicProc.Name = "InicProc";
            this.InicProc.Size = new System.Drawing.Size(75, 23);
            this.InicProc.TabIndex = 1;
            this.InicProc.Text = "Iniciar Proc.";
            this.InicProc.UseVisualStyleBackColor = true;
            this.InicProc.Click += new System.EventHandler(this.InicProc_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(71, 30);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 267);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.InicProc);
            this.Controls.Add(this.Liberar);
            this.Controls.Add(this.Reiniciar);
            this.Controls.Add(this.Pausar);
            this.Controls.Add(this.Controlar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Controlar;
        private System.Windows.Forms.Button Pausar;
        private System.Windows.Forms.Button Reiniciar;
        private System.Windows.Forms.Button Liberar;
        private System.Windows.Forms.Button InicProc;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

