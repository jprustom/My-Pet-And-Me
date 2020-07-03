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
    public partial class LoginForm : Form
    {
        HistoryForm historyForm;
        List<Player> ListOfPlayersProfile { get; set; }
        public LoginForm(HistoryForm historyForm, List<Player> listOfPlayersProfiles)
        {
            ListOfPlayersProfile = listOfPlayersProfiles;
            this.historyForm = historyForm;
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (playerNameTextBox.Text == "" || ageComboBox.SelectedItem==null)
                return;

            Player newPlayer = new Player(playerNameTextBox.Text, int.Parse(ageComboBox.SelectedItem as string));
            if (ListOfPlayersProfile == null)
                ListOfPlayersProfile = new List<Player>();
            ListOfPlayersProfile.Add(newPlayer);
            historyForm.AddToListBox(newPlayer);

            MenuForm menuForm = new MenuForm(newPlayer, true,historyForm);
            menuForm.Show();
        }

        
    }
}
