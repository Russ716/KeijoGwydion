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