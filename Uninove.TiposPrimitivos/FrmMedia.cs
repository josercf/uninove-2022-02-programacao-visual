using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uninove.TiposPrimitivos
{
    public partial class FrmMedia : Form
    {
        public FrmMedia()
        {
            InitializeComponent();
        }

        private void btnCalcularMedia_Click(object sender, EventArgs e)
        {
            //float nota01 = (float)Convert.ToDouble(txtNota01.Text);
            var nota01 = float.Parse(txtNota01.Text);
            var nota02 = float.Parse(txtNota02.Text);
            var nota03 = float.Parse(txtNota03.Text);

            float media = (nota01 + nota02 + nota03) / 3;


            //if(media >= 6)
            //    lblResultado.Text = "Aprovado";
            //else
            //    lblResultado.Text = "Reprovado";


            lblResultado.Text = media >= 6 ? "Aprovado" : "Reprovado";

            //pergunta (operação lógica) ? se verdadeiro : se falso

        }
    }
}
