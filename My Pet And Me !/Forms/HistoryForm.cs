using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace My_Pet_And_Me__
{
    public partial class HistoryForm : Form
    {
        public List<Player> ListOfPlayersProfiles { get; set; }
        public ListBox GetPlayersHistoryListBox => historyListBox;
        MenuForm openMenuForm =>(MenuForm)Application.OpenForms["MenuForm"];
        Player SelectedPlayer => historyListBox.SelectedItem as Player;
        public HistoryForm()
        {

            InitializeComponent();
            /*File.SetAttributes(Paths.PlayerProfilesPath, FileAttributes.Normal);
            XmlSerializer deserializer = new XmlSerializer(typeof(List<Player>));
            TextReader reader = new StreamReader(Paths.PlayerProfilesPath);
            object deserializedObject = deserializer.Deserialize(reader) ;
            if (deserializedObject != null)
            {
                ListOfPlayersProfiles = deserializedObject as List<Player>;
                foreach (var player in ListOfPlayersProfiles)
                    historyListBox.Items.Add(player);
            }
            else ListOfPlayersProfiles = new List<Player>();
            reader.Close();*/

            

            if (historyListBox.Items.Count == 0)
                ShowLoginForm();

            
        }
        

        public void AddToListBox(Player player)
        {
            if (historyListBox == null)
                historyListBox = new ListBox();

            historyListBox.Items.Add(player);

        }

        private void newGameBtn_Click(object sender, EventArgs e) { 
            ShowLoginForm(); 
        }

        private void ShowLoginForm()
        {    
            LoginForm loginForm = new LoginForm(this,ListOfPlayersProfiles);
            loginForm.ShowDialog();
        }


        private void loadPlayerBtn_Click(object sender, EventArgs e)
        {
            if (historyListBox.SelectedIndex == -1)
                return;

            if (CheckIfAlreadyPlaying())
                return;

            MenuForm menuForm = new MenuForm(player: SelectedPlayer, isNewGame: false, historyForm: this);
            menuForm.Show();
        }

        private bool CheckIfAlreadyPlaying()
        {
            if (openMenuForm != null)
            {
                MessageBox.Show("Can't Run Two Games Simultaneously!");
                return true;
            }
            return false;
        }

        private void deletePlayerBtn_Click(object sender, EventArgs e)
        {
           
            if (historyListBox.SelectedIndex == -1)
                return;

            if (!ProfileToDeleteCurrentlyPlaying())
                RemovePlayer();

        }

        private void RemovePlayer()
        {
            DialogResult dialogResult = MessageBox.Show($"Delete {SelectedPlayer.PlayerName}'s Profile ?", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                historyListBox.Items.Remove(SelectedPlayer);
            }
         
        }

        bool ProfileToDeleteCurrentlyPlaying()
        {
            if (openMenuForm == null)
                return false;

            if (openMenuForm.CurrentPlayer == SelectedPlayer)
            {
                MessageBox.Show($"{SelectedPlayer.PlayerName}, You Have To Quit Before Deleting Your Profile !");
                return true;
            }
            return false;
        }

        private void HistoryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show($"Have A Nice { DateTime.Now.DayOfWeek}!","Goodbye Amigos...");
            /*Directory.CreateDirectory(Paths.PlayerProfilesPath);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Player>));
            using (TextWriter tw=new StreamWriter(Paths.PlayerProfilesPath))
            {
                serializer.Serialize(tw, ListOfPlayersProfiles);
            }*/
        }
    }
}
