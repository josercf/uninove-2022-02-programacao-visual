namespace Uninove.TiposPrimitivos
{
    partial class FrmMedia
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnCalcularMedia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNota01 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtNota03 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNota02 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(41, 24);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 15);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(101, 21);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(386, 23);
            this.txtNome.TabIndex = 1;
            // 
            // btnCalcularMedia
            // 
            this.btnCalcularMedia.Location = new System.Drawing.Point(186, 293);
            this.btnCalcularMedia.Name = "btnCalcularMedia";
            this.btnCalcularMedia.Size = new System.Drawing.Size(327, 97);
            this.btnCalcularMedia.TabIndex = 5;
            this.btnCalcularMedia.Text = "Calcular Média";
            this.btnCalcularMedia.UseVisualStyleBackColor = true;
            this.btnCalcularMedia.Click += new System.EventHandler(this.btnCalcularMedia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nota 01:";
            // 
            // txtNota01
            // 
            this.txtNota01.Location = new System.Drawing.Point(101, 77);
            this.txtNota01.Name = "txtNota01";
            this.txtNota01.Size = new System.Drawing.Size(100, 23);
            this.txtNota01.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Resultado:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(240, 238);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 15);
            this.lblResultado.TabIndex = 6;
            // 
            // txtNota03
            // 
            this.txtNota03.Location = new System.Drawing.Point(101, 168);
            this.txtNota03.Name = "txtNota03";
            this.txtNota03.Size = new System.Drawing.Size(100, 23);
            this.txtNota03.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nota 03:";
            // 
            // txtNota02
            // 
            this.txtNota02.Location = new System.Drawing.Point(101, 122);
            this.txtNota02.Name = "txtNota02";
            this.txtNota02.Size = new System.Drawing.Size(100, 23);
            this.txtNota02.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nota 02:";
            // 
            // FrmMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNota02);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNota03);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNota01);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcularMedia);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "FrmMedia";
            this.Text = "FrmMedia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private Button btnCalcularMedia;
        private Label label1;
        private TextBox txtNota01;
        private Label label2;
        private Label lblResultado;
        private TextBox txtNota03;
        private Label label3;
        private TextBox txtNota02;
        private Label label4;
    }
}