using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAN_Switch_GUI.Clases
{
    internal class RadioButtonController
    {
        RadioButton thirdRadioButton;

        public RadioButtonController(RadioButton thirdRadioButton) 
        {
            this.thirdRadioButton = thirdRadioButton;
        }

        public void SetRadioButtonsNumber(int numberOfRadioButtons)
        {
            if (numberOfRadioButtons == 2)
            {
                thirdRadioButton.Visible = false;
            }
            else if (numberOfRadioButtons == 3)
            {
                thirdRadioButton.Visible = true;
            }
        }
    }
}
