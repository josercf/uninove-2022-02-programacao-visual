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
            
            MessageBox.Show(this, "Olá, " + txtNome.Text, "Saudação");


            lblNome.Text = "Apelido";
        

        }
    }
}
