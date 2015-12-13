using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steganography
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void Encrypting1_Click(object sender, EventArgs e)
        {
            Encrypting temp = new Encrypting();
            temp.Show();
            Hide();
        }

        private void Decrypting1_Click(object sender, EventArgs e)
        {
            Decrypting temp = new Decrypting();
            temp.Show();
            Hide();
        }

        private void MainScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Help_Click(object sender, EventArgs e)
        {
            Helper temp = new Helper();
            temp.Show();
            temp.Helping.LoadFile("Helper/Help1.rtf");
        }
    }
}
