using Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Engine {
    public class Location {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Location(int id, string name, string description, Item itemRequiredToEnter = null, Quest questAvailableHere = null, Monster monsterLivingHere = null) {
            //Notice that after each of the new parameters, there is ” = null”. Some locations won’t have an item required to enter them, a quest available at them, or a monster living there. This lets us call the Location constructor without passing these three values. The constructor will know to use the default values, which, in this case, is the “null”. 


            ID = id;
            Name = name;
            //Properties & parameters
            Description = description;
            /*This is our new constructor code.
}

It starts out with “public”, because we want to be able to create a new Location object from anywhere in the solution. Then it has the name of the class. After that, we see three “parameters” between the parentheses.

When you run a function, or method (like a constructor), it can accept values. These are called parameters. In C#, you need to declare the datatype of the parameter and its name. In this constructor, there are three parameters: id (an integer), name (a string), and description (another string).

Notice that the names of the parameters match the names of the properties, except they are all lower-case. By having a different case from the property, it’s more obvious when you’re working with the property and when you’re working with the parameter value. They don’t need to match the property name, but I do that to make it obvious what the parameters are going to be used for.

So, now when you call the Location constructor, you’ll need to pass in these three values.*/
            ItemRequiredToEnter = itemRequiredToEnter;
            QuestAvailableHere = questAvailableHere;
            MonsterLivingHere = monsterLivingHere;
        }
            //we want to possibly store an item required to enter the location (such as a key). If there is a quest available at that location, we need to store that value. We also might have a monster that exists in that location. So we need to add some new properties to the Location class, to store these values.
        
        public Item ItemRequiredToEnter { get; set; }
        public Quest QuestAvailableHere { get; set; }
        public Monster MonsterLivingHere { get; set; }
        //Now we have properties to hold these values for each location. Because we need to store an Item object in the ItemRequiredToEnter property, its datatype is Item. Just like using a string datatype when we want to store some text in a property.

        public Location LocationToNorth { get; set; }
        public Location LocationToEast { get; set; }
        public Location LocationToSouth { get; set; }
        public Location LocationToWest { get; set; }

    }
}


