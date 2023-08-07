using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Engine {
    public class HealingPotion : Item {
        //Adding the colon and Item class name after the HealingPotion class name is how we show that HealingPotion has a base class of Item. So, all the public properties and methods from the Item class now automatically show up in the HealingPotion class, even after we delete the lines for the ID, Name, and NamePlural properties.
/*HealingPotion is now a “child class”, or “derived class”, from the Item class. Those are the common terms you’ll hear other programmers use, for classes that inherit from another class.

Now, we can remove the ID, Name, and NamePlural properties from HealingPotion, since they are in the base class.

One of the most popular benefits of a base class is that you don’t need to duplicate properties and methods in all of its child classes. Child classes have access to variables/properties/methods/etc. that are in the base class – as long as their scope is not “private”. Anything that is private is only visible inside the base class.

So, the ID, Name, and NamePlural properties are now “in” the HealingPotion class, because they are in its base class, and not private.*/
public int AmountToHeal { get; set; }
public HealingPotion(int id, string name, string namePlural, int amountToHeal) : base(id, name, namePlural) { //What that does is take the values from the parameters in the HealingPotion constructor (id, name, and namePlural) and passes them on to the constructor of the Item class. This is how we get parameters into the base class, when instantiating a derived class.
            AmountToHeal = amountToHeal;}
    }
}
/*Use a potion function

Get currently selected potion from cboPotions ComboBox
Add healing amount to player’s CurrentHitPoints
    CurrentHitPoints cannot exceed player’s MaximumHitPoints
Remove the potion from the player’s inventory
Display message
Monster gets their turn to attack
    Determine the amount of damage the monster does to the player
    Display message
    Subtract damage from player’s CurrentHitPoints
        Refresh player data in UI
    If player is dead (zero hit points remaining)
        Display message
        Move player to “Home” location
Refresh player data in UI*/