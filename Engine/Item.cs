using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Engine {
    public class Item {
        // HealingPotion, Item, and Weapon all have the properties ID, Name, and NamePlural. They all also represent items that a player may collect during a game.
        // Item will be the base class, and Weapon & HealingPotion will use inheritance
        public int ID { get; set; }
        public string Name { get; set; }
        public string NamePlural { get; set; }
        public Item(int id, string name, string namePlural) {
            ID = id;
            Name = name;
            NamePlural = namePlural;
        }
    }
}