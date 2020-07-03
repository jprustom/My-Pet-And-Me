using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Pet_And_Me__
{
    public partial class HelperForm : Form
    {
        public string PlayerName { get; set; }
        public HelperForm(Player currentPlayer)
        {
            InitializeComponent();

            PlayerName = currentPlayer.PlayerName;
            HelperSingelton.LoadHelper(this);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
