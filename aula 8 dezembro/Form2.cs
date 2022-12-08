using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula_8_dezembro
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void keyDown(object sender, KeyEventArgs e)
        {

            tela.AppendText("\r\n" + "precionei a tecla: " + e.KeyCode);
            tela.AppendText("\r\n" + "\t" + "Codigo da tecla: " + ((int)e.KeyCode));

        }

        private void botaolimpa_Click(object sender, EventArgs e)
        {
            tela.Text = "false;
        }
    }
}
