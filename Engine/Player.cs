using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine {
    public class Player : LivingCreature{
        
        public int Gold { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }
        public Player(int currentHitPoints, int maximumHitPoints, int gold, int experiencePoints, int level) : base(currentHitPoints, maximumHitPoints) {
            Gold = gold;
            ExperiencePoints = experiencePoints;
            Level = level;
            Inventory = new List<InventoryItem>();
            Quests = new List<PlayerQuest>();
            //^ These set the value of the new properties to empty lists so items can be added later. Otherwise, value would be null, and can't add object to null. 
        }
        public List<InventoryItem> Inventory { get; set; }
        public List<PlayerQuest> Quests { get; set; }
        // ^ Two properties that can hold lists containing InvItem and PlyrQst objects
    }
}
/* 
 * First, we’ll start with “public”. This is known as the “scope”. It signifies what other parts of the solution can see the class or property. “Public” means that it is visible throughout the whole solution. This way, the UI project will be able to create a Player object and read the values of its properties.

These are the properties of the Player class. They’re public, since we need to have them visible everywhere. The “int” says that their datatype is an integer. Then we have the name of the property. Finally, there is a “{ get; set; }” after each property. Those signifies that we have a property where we can “get” a value (read what is stored in the property) and “set” a value (store a value in the property). 
 */