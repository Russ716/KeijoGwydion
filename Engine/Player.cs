using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine {
    public class Player : LivingCreature {
        public int Gold { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }
        public Location CurrentLocation { get; set; }
        public List<InventoryItem> Inventory { get; set; }
        public List<PlayerQuest> Quests { get; set; }

        public Player(int currentHitPoints, int maximumHitPoints, int gold, int experiencePoints, int level) : base(currentHitPoints, maximumHitPoints) {
            Gold = gold;
            ExperiencePoints = experiencePoints;
            Level = level;

            Inventory = new List<InventoryItem>();
            Quests = new List<PlayerQuest>();
        }

        public bool HasRequiredItemToEnterThisLocation(Location location) {
            if (location.ItemRequiredToEnter == null) {
                // There is no required item for this location, so return "true"
                return true;
            }

            // See if the player has the required item in their inventory
            foreach (InventoryItem ii in Inventory) {
                if (ii.Details.ID == location.ItemRequiredToEnter.ID) {
                    // We found the required item, so return "true"
                    return true;
                }
            }

            // We didn't find the required item in their inventory, so return "false"
            return false;
        }

        public bool HasThisQuest(Quest quest) {
            foreach (PlayerQuest playerQuest in Quests) {
                if (playerQuest.Details.ID == quest.ID) {
                    return true;
                }
            }

            return false;
        }

        public bool CompletedThisQuest(Quest quest) {
            foreach (PlayerQuest playerQuest in Quests) {
                if (playerQuest.Details.ID == quest.ID) {
                    return playerQuest.IsCompleted;
                }
            }

            return false;
        }

        public bool HasAllQuestCompletionItems(Quest quest) {
            // See if the player has all the items needed to complete the quest here
            foreach (QuestCompletionItem qci in quest.QuestCompletionItems) {
                bool foundItemInPlayersInventory = false;

                // Check each item in the player's inventory, to see if they have it, and enough of it
                foreach (InventoryItem ii in Inventory) {
                    if (ii.Details.ID == qci.Details.ID) // The player has the item in their inventory
                    {
                        foundItemInPlayersInventory = true;

                        if (ii.Quantity < qci.Quantity) // The player does not have enough of this item to complete the quest
                        {
                            return false;
                        }
                    }
                }

                // The player does not have any of this quest completion item in their inventory
                if (!foundItemInPlayersInventory) {
                    return false;
                }
            }

            // If we got here, then the player must have all the required items, and enough of them, to complete the quest.
            return true;
        }

        public void RemoveQuestCompletionItems(Quest quest) {
            foreach (QuestCompletionItem qci in quest.QuestCompletionItems) {
                foreach (InventoryItem ii in Inventory) {
                    if (ii.Details.ID == qci.Details.ID) {
                        // Subtract the quantity from the player's inventory that was needed to complete the quest
                        ii.Quantity -= qci.Quantity;
                        break;
                    }
                }
            }
        }

        public void AddItemToInventory(Item itemToAdd) {
            foreach (InventoryItem ii in Inventory) {
                if (ii.Details.ID == itemToAdd.ID) {
                    // They have the item in their inventory, so increase the quantity by one
                    ii.Quantity++;

                    return; // We added the item, and are done, so get out of this function
                }
            }

            // They didn't have the item, so add it to their inventory, with a quantity of 1
            Inventory.Add(new InventoryItem(itemToAdd, 1));
        }

        public void MarkQuestCompleted(Quest quest) {
            // Find the quest in the player's quest list
            foreach (PlayerQuest pq in Quests) {
                if (pq.Details.ID == quest.ID) {
                    // Mark it as completed
                    pq.IsCompleted = true;

                    return; // We found the quest, and marked it complete, so get out of this function
                }
            }
        }
    }
}


/* ! Delete this comment opener only to get the original code. 
 * 
 * using System;
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
            // We didn’t need to set the string, integer, and Boolean properties to a default value because those datatypes have a built-in default value. However, Lists are null (non-existent), until you set them to an empty list (a new List object, with no values in it yet).


        }
        public List<InventoryItem> Inventory { get; set; }
        public List<PlayerQuest> Quests { get; set; }
        // ^ Two properties that can hold lists containing InvItem and PlyrQst objects
        public Location CurrentLocation { get; set; }
    }
}
/* 
 * First, we’ll start with “public”. This is known as the “scope”. It signifies what other parts of the solution can see the class or property. “Public” means that it is visible throughout the whole solution. This way, the UI project will be able to create a Player object and read the values of its properties.

These are the properties of the Player class. They’re public, since we need to have them visible everywhere. The “int” says that their datatype is an integer. Then we have the name of the property. Finally, there is a “{ get; set; }” after each property. Those signifies that we have a property where we can “get” a value (read what is stored in the property) and “set” a value (store a value in the property). 
 */
