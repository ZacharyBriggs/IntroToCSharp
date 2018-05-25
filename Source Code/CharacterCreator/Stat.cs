using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class Stat
    {
        public string Name;
        public int Value;
        public int Growth;
        public int Max;
        public string Description;

        /*Prototype: public Stat();
	    Description: Default constructor for Stat.
	    Arguments: None.
	    Precondition: None.
	    Postcondition: A new stat is created.
	    Protection: Public.*/
        public Stat()
        {

        }

        /*Prototype: public Stat(string name, int value, int growth, int max);
	    Description: Overloaded constructor for Stat.
	    Arguments: string representing Name and three ints representing Value, Growth, and Max.
	    Precondition: None.
	    Postcondition: A new stat is created with the values passed in.
	    Protection: Public.*/
        public Stat(string name, int value, int growth, int max)
        {
            Name = name;
            Value = value;
            Max = max;
            Growth = growth;
        }

        /*Prototype: public Stat(string name, int value, int growth, int max, string description);
	    Description: Overloaded constructor for Stat.
	    Arguments:  two strings representing Name and Description and three ints representing Value, Growth, and Max.
	    Precondition: None.
	    Postcondition: A new stat is created with the values passed in.
	    Protection: Public.*/
        public Stat(string name, int value, int growth, int max, string description)
        {
            Name = name;
            Value = value;
            Growth = growth;
            Max = max;
            Description = description;
        }
    }
}
