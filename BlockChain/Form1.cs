using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlockChain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DETAILS_Click(object sender, EventArgs e)
        {
            DETAILS det = new DETAILS();
            det.ShowDialog();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            ADD add = new ADD();
            add.ShowDialog();
        }

        private void btnBlockChain_Click(object sender, EventArgs e)
        {
            BlockChain form = new BlockChain();
            form.ShowDialog();
        }
    }
}
