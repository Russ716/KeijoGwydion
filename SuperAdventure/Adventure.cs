using Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperAdventure {
    public partial class Adventure : Form {
        private Player _player;
        // The scope here is “private”, since we don’t need anything outside of this screen to use the variable. The datatype is “Player”, because we want to store a Player object in it. And the variable name is “_player”. 


        public Adventure() {
            InitializeComponent();
            Location location = new Location(1, "Home", "This is your house.");
            location.ID = 1;
            location.Name = "Home";
            location.Description = "This is your house.";
            _player = new Player(10, 10, 20, 0, 1);
            /* Built class constructors with derived classes to replace this with the above
            _player = new Player();
            ^ This creates a new Player object (that’s what is happening on the right side of the equal sign). Then it assigns that object to the _player variable 
            _player.CurrentHitPoints = 10;
            _player.MaximumHitPoints = 10;
            _player.Gold = 20;
            _player.ExperiencePoints = 0;
            _player.Level = 1; 
            ^ These lines assign vallues to the object properties. */
            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExperience.Text = _player.ExperiencePoints.ToString();
            lblLevel.Text = _player.Level.ToString();
            //^ In these lines, we’re getting the values of the properties from the _player object, and assigning them to the text of the labels on the screen, changing from integer ToString.


        }
        //The ComboBoxes will let the player select which weapon, or potion, they want to use during a battle. The RichTextBoxes will display status information about where the player is at and what is happening to them. And the DataGridViews will show lists of what the player has in their inventory and what quests they have.


        private void label5_Click(object sender, EventArgs e) {

        }

        private void btnNorth_Click(object sender, EventArgs e) {

        }

        private void btnEast_Click(object sender, EventArgs e) {

        }

        private void btnSouth_Click(object sender, EventArgs e) {

        }

        private void btnWest_Click(object sender, EventArgs e) {

        }

        private void btnUseWeapon_Click(object sender, EventArgs e) {

        }

        private void btnUsePotion_Click(object sender, EventArgs e) {

        }
    }

}
/*
 Controls are the things you see on a program’s, or a website’s, screen – text, boxes to enter values, buttons. In Visual Studio, when you’re working with a form, you’ll see a list of controls on the left side. We’re going to use some of the common controls.

The first controls we’re going to add are “labels”. These are used when you want to display a small piece of text. 
  */

