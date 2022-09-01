namespace Uninove.TiposPrimitivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte quantidade = 200;

            short quantidadeShort = quantidade;

            int quantidadeInt = quantidadeShort;

            long quantidadeLong = quantidadeInt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            long quantidadeLong = 256;

            //Forma 01
            //Cast
            int quantidadeInt = (int) quantidadeLong;

            //Forma 02
            //Conversão explícita
            //int quantidadeInt = Convert.ToInt16(quantidadeLong);

            short quantidadeShort = (short) quantidadeInt;
                        
            byte quantidade = Convert.ToByte(quantidadeShort);
        }
    }
}