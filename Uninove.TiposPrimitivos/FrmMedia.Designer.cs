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
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(32, 24);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 15);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(81, 21);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(230, 23);
            this.txtNome.TabIndex = 1;
            // 
            // btnCalcularMedia
            // 
            this.btnCalcularMedia.Location = new System.Drawing.Point(186, 293);
            this.btnCalcularMedia.Name = "btnCalcularMedia";
            this.btnCalcularMedia.Size = new System.Drawing.Size(327, 97);
            this.btnCalcularMedia.TabIndex = 2;
            this.btnCalcularMedia.Text = "Calcular Média";
            this.btnCalcularMedia.UseVisualStyleBackColor = true;
            this.btnCalcularMedia.Click += new System.EventHandler(this.btnCalcularMedia_Click);
            // 
            // FrmMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}