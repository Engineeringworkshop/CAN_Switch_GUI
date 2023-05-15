using CAN_Switch_GUI.Clases;

namespace CAN_Switch_GUI
{
    public partial class Form1 : Form
    {
        // Modules
        private LogController logController;
        private DeviceController deviceController;
        private RadioButtonController radioButtonController;

        public Form1()
        {
            InitializeComponent();

            // Create instance of modules
            logController = new LogController(lbl_Log);
            radioButtonController = new RadioButtonController(radBtn_Rack3);
            deviceController = new DeviceController(logController, radioButtonController);

            StartRoutine();
        }

        private void StartRoutine()
        {


        }

        private void radBtn_Disconect_CheckedChanged(object sender, EventArgs e)
        {
            if (radBtn_Disconect.Checked)
            {
                deviceController.ChangeSelection(SwitchStates.Disconnect);
            }
        }

        private void radBtn_Rack1_CheckedChanged(object sender, EventArgs e)
        {
            if (radBtn_Rack1.Checked)
            {
                deviceController.ChangeSelection(SwitchStates.Rack1);
            }
        }

        private void radBtn_Rack2_CheckedChanged(object sender, EventArgs e)
        {
            if (radBtn_Rack2.Checked)
            {
                deviceController.ChangeSelection(SwitchStates.Rack2);
            }
        }

        private void radBtn_Rack3_CheckedChanged(object sender, EventArgs e)
        {
            if (radBtn_Rack3.Checked)
            {
                deviceController.ChangeSelection(SwitchStates.Rack3);
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            deviceController.AutodetectArduinoPort();
        }
    }
}