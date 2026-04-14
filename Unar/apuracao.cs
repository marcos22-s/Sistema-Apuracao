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
    public partial class apuracao : Form
    {
        public apuracao()
        {
            InitializeComponent();
        }

        private void apuracao_Load(object sender, EventArgs e)
        {
                                                                                                                                                label1.Text = Convert.ToString(Controle.abacate);
            label2.Text = Convert.ToString(Controle.banana);
            label3.Text = Convert.ToString(Controle.laranja);
            label4.Text = Convert.ToString(Controle.goiaba);
            label10.Text = Convert.ToString(Controle.total);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
