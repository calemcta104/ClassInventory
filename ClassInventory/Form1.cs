using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassInventory
{
    public partial class Form1 : Form
    {
        // TODO - create a List to store all inventory objects
        List<players> teamList = new List<players>();

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // TODO - gather all information from screen
            string name = nameInput.Text;
            int age = Convert.ToInt32(ageInput.Text);
            string team = teamInput.Text;
            string position = positionInput.Text;

            // TODO - create object with gathered information
            players newplayer = new players(name, age, team, position);

            newplayer.name = (nameInput.Text);
            newplayer.age = Convert.ToInt32(ageInput.Text);
            newplayer.team = teamInput.Text;
            newplayer.position = (positionInput.Text);

            // TODO - add object to global list
            teamList.Add(newplayer);

            // TODO - display message to indicate addition made
            outputLabel.Text = "Player added.";
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
          //You will use Foreach loop here.
          // foreach (players p in teamList)
          // {
          //     //TODO - if object is in list remove it
          //     if (p.name == removeInput.Text)
          //     {
          //         teamList.Remove(p);
;         //      }
          //  }

            int index = teamList.FindIndex(n => n.name == removeInput.Text);

            if (index >= 0)
            {
                teamList.RemoveAt(index);
            }

            // TODO - display message to indicate deletion made
            outputLabel.Text = "Player removed.";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // TODO - if object entered exists in list show it
            try
            {
                players playr = teamList.Find(x => x.name == searchInput.Text);
                outputLabel.Text = playr.name + " " + playr.age;
            }
            catch
            {
                // TODO - else show not found message
                outputLabel.Text = "Player not found.";
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            // TODO - show all objects in list
            outputLabel.Text = "\n";
            foreach (players p in teamList)
            {
                outputLabel.Text += p.name + "\n";
                outputLabel.Text += p.age + "\n";
                outputLabel.Text += p.team + "\n";
                outputLabel.Text += p.position + "\n\n";
            }

        }
    }
}
