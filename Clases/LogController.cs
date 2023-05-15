using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAN_Switch_GUI.Clases
{
    internal class LogController
    {
        private Label _label;

        // Constructor
        public LogController(Label label)
        {
            _label = label;
        }

        // Method to show text on the log window
        public void ShowLogText(string text)
        {
            _label.Text = text;
        }
    }
}
