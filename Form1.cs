using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFrotaV3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MenuAdm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void ClosetM_Paint(object sender, PaintEventArgs e)
        {
            // Esconde o menu
            MenuAdm.Hide();

            // Substitui o panel ClosetM pelo panel OpenM
            Controls.Remove(ClosetM);
            Controls.Add(OpenM);
        }

        private void OpenM_Paint(object sender, PaintEventArgs e)
        {
            // Mostra o menu
            MenuAdm.Show(OpenM, new Point(OpenM.Width, 0));

            // Substitui o panel OpenM pelo panel ClosetM
            Controls.Remove(OpenM);
            Controls.Add(ClosetM);
        }
    }
}
