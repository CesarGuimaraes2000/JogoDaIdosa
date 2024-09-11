using System.Numerics;

namespace Velha
{
    public partial class Form1 : Form
    {
        bool Op = false;
        int round = 0;
        int[,] mat = new int[4, 4];
        public Form1()
        {

            InitializeComponent();
            round = 0;
            resetMat();
        }

        private void imprimeMat()
        {
            string a = "";
            for (int i = 0; i < 3; i++)
            {
                a += '\n';
                for (int j = 0; j < 3; j++)
                {
                    a += (mat[i, j]).ToString();
                }
            }
            MessageBox.Show(a);
        }

        private void resetMat()
        {
            Fake();
            foreach (Control c in this.Controls)
            {
                if (c is Button && c != button1 && c != buttonOp && c != buttonFake && c != buttondeb)
                {
                    ((Button)c).Text = " ";
                    ((Button)c).Enabled = true;
                    ((Button)c).BackColor = Color.White;

                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    mat[i, j] = 0;
                }
            }
        }

        private void block()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button && c != button1 && c != buttonOp && c != buttonFake && c != buttondeb)
                {
                    ((Button)c).Enabled = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            round = 0;
            resetMat();

        }

        private int checkV()
        {
            int res = 0;
            int s = 0;
            for (int i = 0; i < 3 && res != 3 && res != -3; i++)
            {
                s = 0;
                for (int j = 0; j < 3; j++)
                {
                    s += mat[i, j];
                }
                if (s == 3 || s == -3)
                {
                    res = s;
                    break;
                }
            }
            for (int i = 0; i < 3 && res != 3 && res != -3; i++)
            {
                s = 0;
                for (int j = 0; j < 3; j++)
                {
                    s += mat[j, i];
                }
                if (s == 3 || s == -3)
                {
                    res = s;
                    break;
                }
            }
            s = 0;
            if (res != 3 && res != -3)
            {
                s = mat[0, 0] + mat[1, 1] + mat[2, 2];
                if (s == 3 || s == -3)
                {
                    res = s;
                }
            }
            s = 0;
            if (res != 3 && res != -3)
            {
                s = mat[0, 2] + mat[1, 1] + mat[2, 0];
                if (s == 3 || s == -3)
                {
                    res = s;
                }
            }
            return res;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            int v = 0;
            if (Op)
            {
                ((Button)sender).Enabled = false;
                ((Button)sender).BackColor = Color.Gray;
                int x = Int32.Parse((((Button)sender).Name).Substring(6, 1));
                int y = Int32.Parse((((Button)sender).Name).Substring(7, 1));
                mat[x, y] = 1;
                ((Button)sender).Text = "X";
                v = checkV();
                if (v == 3)
                {
                    MessageBox.Show("Voce venceu");
                    block();
                }
                else if (round < 9)
                {
                    round++;
                }
                if (v != 3 && round < 9)
                {
                    Fazer_Jogada();
                }
                if (round == 9)
                {
                    MessageBox.Show("Empate");
                    block();
                }
            }
            else
            {
                ((Button)sender).Enabled = false;
                ((Button)sender).BackColor = Color.Gray;
                int x = Int32.Parse((((Button)sender).Name).Substring(6, 1));
                int y = Int32.Parse((((Button)sender).Name).Substring(7, 1));
                if (round % 2 == 0)
                {
                    mat[x, y] = 1;
                    ((Button)sender).Text = "X";
                }
                else
                {
                    mat[x, y] = -1;
                    ((Button)sender).Text = "O";
                }
                v = checkV();
                if (v == 3)
                {
                    MessageBox.Show("X é o vencedor");
                    block();
                }
                else
                {
                    if (v == -3)
                    {
                        MessageBox.Show("0 é o vencedor");
                        block();
                    }
                    else
                    {
                        if (round <= 8)
                        {
                            round++;
                        }
                        if (round == 9)
                        {
                            MessageBox.Show("Empate");
                            block();
                        }
                    }
                }

            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Fazer_Jogada()
        {
            Random num = new Random();
            bool played = false;
            int x, y;
            do
            {
                x = num.Next(3);
                y = num.Next(3);
                foreach (Control c in this.Controls)
                {
                    if (c is Button && c != button1 && c != buttonOp && c != buttonFake && c != buttondeb)
                    {
                        if (((Button)c).Enabled == true && x == (Int32.Parse((((Button)c).Name).Substring(6, 1))) && y == (Int32.Parse((((Button)c).Name).Substring(7, 1))))
                        {
                            ((Button)c).Enabled = false;
                            ((Button)c).BackColor = Color.Gray;
                            mat[x, y] = -1;
                            ((Button)c).Text = "O";
                            played = true;
                            round++;
                        }
                    }
                }
            } while (!played);
            int v = checkV();
            if (v == -3)
            {
                MessageBox.Show("Voce perdeu");
                block();
            }
        }

        private void buttonOp_Click(object sender, EventArgs e)
        {
            Op = !Op;
            round = 0;
            resetMat();
        }

        private void Fake()
        {
            if (!Op)
            {
                buttonFake.Text = "Modo Versus";
            }
            else
            {
                buttonFake.Text = "Modo Contra Computador";
            }
        }

        private void debug_Click(object sender, EventArgs e)
        {
            BotV1 bb = new BotV1(4);
            MessageBox.Show(bb.Jogar().ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonFake_Click(object sender, EventArgs e)
        {

        }
    }
}
