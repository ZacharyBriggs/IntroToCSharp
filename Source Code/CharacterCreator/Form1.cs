using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CharacterCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Character _currentCharacter;

        private Character CurrentCharacter
        {
            get { return _currentCharacter; }
            set
            {
                _currentCharacter = new Character();
                _currentCharacter = value;
                if(onCharacterChanged != null)
                    onCharacterChanged.Invoke(_currentCharacter);
            }
        }

        public delegate void OnCharacterChanged(Character c);

        public OnCharacterChanged onCharacterChanged;

        public int CurrentIndex
        {
            get { return _currentIndex; }
            set
            {
                _currentIndex = value;
                if (_currentIndex > loadedCharacters.Count)
                    _currentIndex = loadedCharacters.Count - 1;
                if (_currentIndex <= 0)
                    _currentIndex = 0;
            }
        }

        /*Prototype: private void UiRefresh(Character c)
	    Description: Changes all the the uiStats stat refrences to the character's stats and then refreshes the uiStats.
	    Arguments: A character.
	    Precondition: A character and a global uiStats.
	    Postcondition: uiStats are set and then refreshed.
	    Protection: Private.*/
        private void UiRefresh(Character c)
        {
            for (int i = 0; i < uiStats.Count; i++)
                uiStats[i].StatRef = c.Stats[i];
            
            uiStats.ForEach(s => s.Refresh());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadedCharacters = new List<Character>();
            uiStats = new List<UIStat>();

            onCharacterChanged += UiRefresh;
            onCharacterChanged += SetBoxes;

            var path = System.IO.Path.Combine(System.Environment.CurrentDirectory, "Characters");
            var files = Directory.GetFiles(path);
            
            foreach (var f in files)
            {
                var jsonstring = File.ReadAllText(f);
                var character = JsonConvert.DeserializeObject<Character>(jsonstring);
                loadedCharacters.Add(character);
            }

            foreach (var c in loadedCharacters)
                listBox1.Items.Add(c.Name);

            ///-----------GROUP TEXTBOXES///
            var hpgroup = new UIValueGrowthMax { ValueRef = hpBox, GrowthRef = hpGrowthBox, MaxRef = maxHpBox };
            var strgroup = new UIValueGrowthMax { ValueRef = strBox, GrowthRef = strGrowthBox, MaxRef = maxStrBox };
            var maggroup = new UIValueGrowthMax { ValueRef = magBox, GrowthRef = magGrowthBox, MaxRef = maxMagBox };
            var skillgroup = new UIValueGrowthMax { ValueRef = skillBox, GrowthRef = skillGrowthBox, MaxRef = maxSkillBox };
            var spdgroup = new UIValueGrowthMax { ValueRef = spdBox, GrowthRef = spdGrowthBox, MaxRef = maxSpdBox };
            var luckgroup = new UIValueGrowthMax { ValueRef = luckBox, GrowthRef = luckGrowthBox, MaxRef = maxLuckBox };
            var defgroup = new UIValueGrowthMax { ValueRef = defBox, GrowthRef = defGrowthBox, MaxRef = maxDefBox };
            var resgroup = new UIValueGrowthMax { ValueRef = resBox, GrowthRef = resGrowthBox, MaxRef = maxResBox };
            
            ///------------STUFF UI IN A LIST/////
            uiStats.Add(new UIStat(new Stat("HP", 0, 0, 0, ""), hpgroup));
            uiStats.Add(new UIStat(new Stat("Str", 0, 0, 0, ""), strgroup));
            uiStats.Add(new UIStat(new Stat("Mag", 0, 0, 0, ""), maggroup));
            uiStats.Add(new UIStat(new Stat("Skill", 0, 0, 0, ""), skillgroup));
            uiStats.Add(new UIStat(new Stat("Spd", 0, 0, 0, ""), spdgroup));
            uiStats.Add(new UIStat(new Stat("Luck", 0, 0, 0, ""), luckgroup));
            uiStats.Add(new UIStat(new Stat("Def", 0, 0, 0, ""), defgroup));
            uiStats.Add(new UIStat(new Stat("Res", 0, 0, 0, ""), resgroup));

            if (loadedCharacters.Capacity == 0)
            {
                var one = new Character("Default");
                listBox1.Items.Add(one.Name);
                loadedCharacters.Add(one);
                listBox1.SelectedIndex = CurrentIndex;
            }

            CurrentCharacter = loadedCharacters[CurrentIndex];
            listBox1.SelectedIndexChanged += new System.EventHandler(Listchanged);
            

        }

        /*Prototype: public void SetBoxes(Character c);
	    Description: Sets the name,className,expValue,lvlValue, and moveValue's text to the characters equivalent values.
	    Arguments: A character.
	    Precondition: A character and text boxes.
	    Postcondition: The text boxes are set to the values of the character's stats.
	    Protection: Public.*/
        public void SetBoxes(Character c)
        {
            nameBox.Text = c.Name;
            classNameBox.Text = c.Job;
            expValueBox.Text = c.Experience.ToString();
            lvlValueBox.Text = c.Level.ToString();
            moveValueBox.Text = c.Move.ToString();
        }

        /*Prototype: public void SetOtherValues(Character c);
	    Description: Sets the character's values that aren't the stats to the values in the equivalent text boxes.
	    Arguments: A character.
	    Precondition: A character and text boxes.
	    Postcondition: The character's stats are set to the values of the text boxes.
	    Protection: Public.*/
        public void SetOtherValues(Character c)
        {
            c.Name = nameBox.Text;
            c.Job = classNameBox.Text;
            c.Experience = int.Parse(expValueBox.Text);
            c.Level = int.Parse(lvlValueBox.Text);
            c.Move = int.Parse(moveValueBox.Text);
        }

        /*Prototype: private void Listchanged(object sender, EventArgs e);
	    Description: Changes the currentCharacter to the listBox's highlighted character when the highlighted character is changed.
	    Arguments: object and eventargs
	    Precondition: uiStats, listbox, currentCharacter, list of all characters.
	    Postcondition: The currentCharacter is changed.
	    Protection: Private.*/
        private void Listchanged(object sender, EventArgs e)
        {
            SetOtherValues(CurrentCharacter);
            uiStats.ForEach(s => s.SetValues());
            var listbox = sender as ListBox;
            CurrentIndex = listBox1.SelectedIndex;
            CurrentCharacter = loadedCharacters[CurrentIndex];
        }

        /*Prototype: private void saveButton_Click(object sender, EventArgs e);
	    Description: Upon clicking the saveButton the currentCharacter's stats are set and all of the characters are serialized. 
        Then the listBox and loadedCharacters lists are cleared out. All of the serialized characters are then loaded back in.
	    Arguments: object and eventargs
	    Precondition: A character,text boxes, somewhere to save the serialized files, a list of characters, a listbox.
	    Postcondition: The characters are serilized out the the folder.
	    Protection: Private.*/
        private void saveButton_Click(object sender, EventArgs e)
        {
            SetOtherValues(CurrentCharacter);
            uiStats.ForEach(s => s.SetValues());
            foreach (var c in loadedCharacters)
            {
                SetOtherValues(CurrentCharacter);
                var jsonstring = JsonConvert.SerializeObject(c);
                var path = System.IO.Path.Combine(System.Environment.CurrentDirectory, "Characters/" + c.Name + ".json");
                File.WriteAllText(path, jsonstring);
            }
            var otherpath = System.IO.Path.Combine(System.Environment.CurrentDirectory, "Characters");
            var files = Directory.GetFiles(otherpath);

            loadedCharacters = new List<Character>();
            listBox1.Items.Clear();
            foreach (var f in files)
            {
                var jsonstring = File.ReadAllText(f);
                var character = JsonConvert.DeserializeObject<Character>(jsonstring);
                loadedCharacters.Add(character);
            }
            foreach (var c in loadedCharacters)
                listBox1.Items.Add(c.Name);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
