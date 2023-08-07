using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Engine {
    public class Weapon : Item {
        //We’re going to make the Item class the base class for HealingPotion and Weapon, since all of those classes have the properties that are in the Item class.
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }
        public Weapon(int id, string name, string namePlural, int minimumDamage, int maximumDamage) : base(id, name, namePlural) {
            MinimumDamage = minimumDamage;
            MaximumDamage = maximumDamage;
        }
    }
}
/*
 * Use a weapon function

Get the currently selected weapon from the cboWeapons ComboBox
Determine the amount of damage the player does to the monster
Apply the damage to the monster’s CurrentHitPoints
    Display message
If the monster is dead (zero hit points remaining)
    Display a victory message
    Give player experience points for killing the monster
        Display message
    Give player gold for killing the monster
        Display message
    Get loot items from the monster
        Display message for each loot item
        Add item to player’s inventory
    Refresh player data on UI
        Gold and ExperiencePoints
        Inventory list and ComboBoxes
    “Move” player to current location
        This will heal the player and create a new monster
If the monster is still alive
    Determine the amount of damage the monster does to the player
    Display message
    Subtract damage from player’s CurrentHitPoints
        Refresh player data in UI
    If player is dead (zero hit points remaining)
        Display message
        Move player to “Home” location

 * */
