using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class UIStat
    {
        /*Prototype: public UIStat(Stat statref, UIValueGrowthMax vgm);
	    Description: Overloaded constructor for UIStat
	    Arguments: A stat representing statRef and a UIValueGrowthMax representing uivalue
	    Precondition: None.
	    Postcondition: A UIStat is created with the values passed in.
	    Protection: Public.*/
        public UIStat(Stat statref, UIValueGrowthMax vgm)
        {
            StatRef = statref;
            uivalue = vgm;
        }
        public Stat StatRef;
        public UIValueGrowthMax uivalue;

        /*Prototype: public void Refresh()
	    Description: Sets the text box refrences' text to the values in the Stat refrence
	    Arguments: None.
	    Precondition: The StatRef have values.
	    Postcondition: The text box refrences are set.
	    Protection: Public.*/
        public void Refresh()
        {
            uivalue.ValueRef.Text = StatRef.Value.ToString();
            uivalue.GrowthRef.Text = StatRef.Growth.ToString();
            uivalue.MaxRef.Text = StatRef.Max.ToString();
        }

        /*Prototype: public void SetValues();
	    Description: The stat refrence is set to the values in the text box refrences.
	    Arguments: None.
	    Precondition: The UIvalue has values.
	    Postcondition: The text box refrences are set.
	    Protection: Public.*/
        public void SetValues()
        {
            StatRef.Value = int.Parse(uivalue.ValueRef.Text);
            StatRef.Growth = int.Parse(uivalue.GrowthRef.Text);
            StatRef.Max = int.Parse(uivalue.MaxRef.Text);

        }
    }
}
