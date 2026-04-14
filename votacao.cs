using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unar
{
    public partial class votacao : Form
    {
        public votacao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            apuracao frmapura = new apuracao();
            frmapura.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Votos para abacate");
            Controle.abacate = Controle.abacate + 1;
            Controle.total = Controle.total + 1;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Votos para banana");
            Controle.banana = Controle.banana+ 1;
            Controle.total = Controle.total + 1;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Votos para laranja");
            Controle.laranja = Controle.laranja + 1;
            Controle.total = Controle.total + 1;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Votos para goiaba");
            Controle.goiaba = Controle.goiaba + 1;
            Controle.total = Controle.total + 1;
        }
    }
}
