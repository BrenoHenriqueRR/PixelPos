using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMarques
{
    public partial class Exibir : Form
    {
        private int x = 0; // Posição horizontal inicial
        private int y = 100; // Posição vertical fixa
        public Exibir()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = 10; // Define o intervalo de atualização da animação em milissegundos
            timer.Tick += new EventHandler(UpdateAnimation);
            timer.Start();
        }

        private void UpdateAnimation(object sender, EventArgs e)
        {
            // Atualiza a posição horizontal do PictureBox
            x += 5; // Altere esse valor para controlar a velocidade da animação

            // Verifica se o PictureBox saiu da tela
            if (x > this.Width)
            {
                x = -pbimagen.Width; // Reinicia a posição se saiu da tela
            }

            // Define a nova posição do PictureBox
            pbimagen.Location = new System.Drawing.Point(x, y);
        }
        public void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
