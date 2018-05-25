using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator
{
    public partial class Form2 : Form
    {
        List<Character> allCharacters = new List<Character>();
        public Form2()
        {
            InitializeComponent();
        }
        public List<UIStat> uistats;

        private void Form2_Load(object sender, EventArgs e)
        {
            currentCharacter = new Character("Current");
            uistats = new List<UIStat>();
            var hpgroup = new UIValueGrowthMax { ValueRef = hpBox, GrowthRef = hpGrowthBox, MaxRef = maxHpBox };
            var strgroup = new UIValueGrowthMax { ValueRef = strBox, GrowthRef = strGrowthBox, MaxRef = maxStrBox };
            var maggroup = new UIValueGrowthMax { ValueRef = magBox, GrowthRef = magGrowthBox, MaxRef = maxMagBox };
            uistats.Add(new UIStat(new Stat() { Value = 0,Max = 0, Growth = 0 }, hpgroup));
            uistats.Add(new UIStat(new Stat() { Value = 0, Max = 0, Growth = 0 }, strgroup));
            uistats.Add(new UIStat(new Stat() { Value = 0, Max = 0, Growth = 0 }, maggroup));
            Character one = new Character("1");
            Character two = new Character("2");
            listBox1.Items.Add(one);
            listBox1.Items.Add(two);
            allCharacters.Add(one);
            allCharacters.Add(two);
        }
        private void hpBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void SaveStat_button_Click(object sender, EventArgs e)
        {
            uistats.ForEach(s => s.Refresh()); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uistats.ForEach(s => s.SetValues());
            for (int i = 0; i < 3; i++)
            {
                currentCharacter.Stats[i].Value = int.Parse(uistats[i].uivalue.ValueRef.Text);
                currentCharacter.Stats[i].Growth = int.Parse(uistats[i].uivalue.GrowthRef.Text);
                currentCharacter.Stats[i].Max = int.Parse(uistats[i].uivalue.MaxRef.Text);
            }
        } 

        /*private void charactersBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var character in allCharacters)
            {
                if (charactersBox.Text == character.Name)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        uistats[i].uivalue.ValueRef.Text = character.Stats[i].Value.ToString();
                        uistats[i].uivalue.GrowthRef.Text = character.Stats[i].Growth.ToString();
                        uistats[i].uivalue.MaxRef.Text = character.Stats[i].Max.ToString();
                    }
                }
            }
        }*/

        private void backButton_Click(object sender, EventArgs e)
        {
            currentCharacter = new Character();
            currentCharacter = allCharacters[0];
            for (int i = 0; i < 3; i++)
            {
                uistats[i].uivalue.ValueRef.Text = currentCharacter.Stats[i].Value.ToString();
                uistats[i].StatRef.Value = currentCharacter.Stats[i].Value;
                uistats[i].uivalue.GrowthRef.Text = currentCharacter.Stats[i].Growth.ToString();
                uistats[i].StatRef.Growth = currentCharacter.Stats[i].Growth;
                uistats[i].uivalue.MaxRef.Text = currentCharacter.Stats[i].Max.ToString();
                uistats[i].StatRef.Max = currentCharacter.Stats[i].Max;
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            currentCharacter = new Character();
            currentCharacter = allCharacters[1];
            for (int i = 0; i < 3; i++)
            {
                uistats[i].uivalue.ValueRef.Text = currentCharacter.Stats[i].Value.ToString();
                uistats[i].StatRef.Value = currentCharacter.Stats[i].Value;
                uistats[i].uivalue.GrowthRef.Text = currentCharacter.Stats[i].Growth.ToString();
                uistats[i].StatRef.Growth = currentCharacter.Stats[i].Growth;
                uistats[i].uivalue.MaxRef.Text = currentCharacter.Stats[i].Max.ToString();
                uistats[i].StatRef.Max = currentCharacter.Stats[i].Max;
            }
        }
    }
}
