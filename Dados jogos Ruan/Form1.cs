namespace WinFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int pontosHomo, pontosmaquina;
        private void btnOk_Click(object sender, EventArgs e)
        {
            Random ObjetoAleatorio1 = new Random();
            int HomoSapiens = ObjetoAleatorio1.Next(1, 7);
            Random ObjetoAleatorio2 = new Random();
            int Maquina = ObjetoAleatorio2.Next(1, 7);

            switch (HomoSapiens)
            {
                case 1:
                    pcbDados.Image = Properties.Resources.Dado1;
                    break;

                case 2:
                    pcbDados.Image = Properties.Resources.Dado2;
                    break;

                case 3:
                    pcbDados.Image = Properties.Resources.Dado3;
                    break;

                case 4:
                    pcbDados.Image = Properties.Resources.Dado4;
                    break;

                case 5:
                    pcbDados.Image = Properties.Resources.Dado5;
                    break;

                case 6:
                    pcbDados.Image = Properties.Resources.Dado6;
                    break;
            }

            switch (Maquina)
            {
                case 1:
                    pcbDados1.Image = Properties.Resources.Dado1;
                    break;

                case 2:
                    pcbDados1.Image = Properties.Resources.Dado2;
                    break;

                case 3:
                    pcbDados1.Image = Properties.Resources.Dado3;
                    break;

                case 4:
                    pcbDados1.Image = Properties.Resources.Dado4;
                    break;

                case 5:
                    pcbDados1.Image = Properties.Resources.Dado5;
                    break;

                case 6:
                    pcbDados1.Image = Properties.Resources.Dado6;
                    break;
            }

            if (HomoSapiens > Maquina)
            {
                pontosHomo = pontosHomo + 1;
            }
            else
            {
                pontosmaquina = pontosmaquina + 1;
            }
            lblPontosSapiens.Text = "" + pontosHomo;
            lblPontosMaquina.Text = "" + pontosmaquina;



        }

        private void txtnome(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
                e.Handled = true;
            if (Char.IsPunctuation(e.KeyChar))
                e.Handled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (pontosHomo > pontosmaquina)
            {
                MessageBox.Show("O Homem venceu o Sistema");
            }

            else if (pontosHomo == pontosmaquina)
            {
                MessageBox.Show("Deu Empate");
            }          

            else
            {
                MessageBox.Show("A Máquina ganhou");
            }
        }
    }
}
