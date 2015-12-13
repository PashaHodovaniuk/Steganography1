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
    public partial class Decrypting : Form
    {
        public Decrypting()
        {
            InitializeComponent();
        }

        private void MainScreenbut_Click(object sender, EventArgs e)
        {
            MainScreen temp = new MainScreen();
            temp.Show();
            Hide();
        }

        private void Exiting_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Decrypting_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
