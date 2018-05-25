using System.Collections.Generic;

namespace CharacterCreator
{
    public class Character
    {
        public int Experience; //Amount of experience the character has.
        public string Job; //Name of character's class
        public int Level; //Current level of character. Goes up by 1 when the character gets 100 experience.
        public int Move; //Number of spaces this character can move.
        public string Name; //Name of the character.
        public List<Stat> Stats; //Combination of this character's base stats, the class base stats,and any stat increases from level ups.

        /*Prototype: public Character();
	    Description: Default constructor for Character class.
	    Arguments: None.
	    Precondition: None.
	    Postcondition: A default character is created.
	    Protection: Public.*/
        public Character()
        {
            Name = "Default";
            Job = "Class";
            Stats = new List<Stat>();
            Level = 1;
            Experience = 0;
            Move = 0;
            CreateStats(Stats);
        }

        /*Prototype: public Character(string name);
	    Description: Overloaded constructor for Character class.
	    Arguments: None.
	    Precondition: None.
	    Postcondition: A default character is created.
	    Protection: Public.*/
        public Character(string name)
        {
            Name = name;
            Job = "Class";
            Stats = new List<Stat>();
            Level = 1;
            Experience = 0;
            Move = 0;
            CreateStats(Stats);
        }

        /*Prototype: public void CreateStats(List<Stat> stats);
	    Description: Creates the default stats for the character.
	    Arguments: A List of stats.
	    Precondition: A list of stats.
	    Postcondition: The stats are added to the lists of stats.
	    Protection: Public.*/
        public void CreateStats(List<Stat> stats)
        {
            stats.Add(new Stat("HP", 0, 0, 0, ""));
            stats.Add(new Stat("Str", 0, 0, 0, ""));
            stats.Add(new Stat("Mag", 0, 0, 0, ""));
            stats.Add(new Stat("Skill", 0, 0, 0, ""));
            stats.Add(new Stat("Spd", 0, 0, 0, ""));
            stats.Add(new Stat("Luck", 0, 0, 0, ""));
            stats.Add(new Stat("Def", 0, 0, 0, ""));
            stats.Add(new Stat("Res", 0, 0, 0, ""));
        }
    }
}