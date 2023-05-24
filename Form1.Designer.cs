namespace CAN_Switch_GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            radBtn_Disconect = new RadioButton();
            radBtn_Rack1 = new RadioButton();
            radBtn_Rack2 = new RadioButton();
            groupBox1 = new GroupBox();
            radBtn_Rack3 = new RadioButton();
            lbl_Log = new Label();
            cmbBox_DeviceList = new ComboBox();
            label1 = new Label();
            btn_Refresh = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // radBtn_Disconect
            // 
            radBtn_Disconect.AutoSize = true;
            radBtn_Disconect.Location = new Point(34, 48);
            radBtn_Disconect.Name = "radBtn_Disconect";
            radBtn_Disconect.Size = new Size(163, 36);
            radBtn_Disconect.TabIndex = 0;
            radBtn_Disconect.TabStop = true;
            radBtn_Disconect.Text = "Disconnect";
            radBtn_Disconect.UseVisualStyleBackColor = true;
            radBtn_Disconect.CheckedChanged += radBtn_Disconect_CheckedChanged;
            // 
            // radBtn_Rack1
            // 
            radBtn_Rack1.AutoSize = true;
            radBtn_Rack1.Location = new Point(34, 90);
            radBtn_Rack1.Name = "radBtn_Rack1";
            radBtn_Rack1.Size = new Size(114, 36);
            radBtn_Rack1.TabIndex = 1;
            radBtn_Rack1.TabStop = true;
            radBtn_Rack1.Text = "Rack 1";
            radBtn_Rack1.UseVisualStyleBackColor = true;
            radBtn_Rack1.CheckedChanged += radBtn_Rack1_CheckedChanged;
            // 
            // radBtn_Rack2
            // 
            radBtn_Rack2.AutoSize = true;
            radBtn_Rack2.Location = new Point(34, 132);
            radBtn_Rack2.Name = "radBtn_Rack2";
            radBtn_Rack2.Size = new Size(114, 36);
            radBtn_Rack2.TabIndex = 2;
            radBtn_Rack2.TabStop = true;
            radBtn_Rack2.Text = "Rack 2";
            radBtn_Rack2.UseVisualStyleBackColor = true;
            radBtn_Rack2.CheckedChanged += radBtn_Rack2_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radBtn_Rack3);
            groupBox1.Controls.Add(radBtn_Disconect);
            groupBox1.Controls.Add(radBtn_Rack2);
            groupBox1.Controls.Add(radBtn_Rack1);
            groupBox1.Location = new Point(51, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(228, 255);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // radBtn_Rack3
            // 
            radBtn_Rack3.AutoSize = true;
            radBtn_Rack3.Location = new Point(34, 174);
            radBtn_Rack3.Name = "radBtn_Rack3";
            radBtn_Rack3.Size = new Size(114, 36);
            radBtn_Rack3.TabIndex = 3;
            radBtn_Rack3.TabStop = true;
            radBtn_Rack3.Text = "Rack 3";
            radBtn_Rack3.UseVisualStyleBackColor = true;
            radBtn_Rack3.CheckedChanged += radBtn_Rack3_CheckedChanged;
            // 
            // lbl_Log
            // 
            lbl_Log.AutoSize = true;
            lbl_Log.Location = new Point(26, 326);
            lbl_Log.Name = "lbl_Log";
            lbl_Log.Size = new Size(100, 32);
            lbl_Log.TabIndex = 4;
            lbl_Log.Text = "Log text";
            // 
            // cmbBox_DeviceList
            // 
            cmbBox_DeviceList.FormattingEnabled = true;
            cmbBox_DeviceList.Location = new Point(402, 100);
            cmbBox_DeviceList.Name = "cmbBox_DeviceList";
            cmbBox_DeviceList.Size = new Size(242, 40);
            cmbBox_DeviceList.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(376, 54);
            label1.Name = "label1";
            label1.Size = new Size(86, 32);
            label1.TabIndex = 6;
            label1.Text = "Device";
            // 
            // btn_Refresh
            // 
            btn_Refresh.Location = new Point(503, 40);
            btn_Refresh.Name = "btn_Refresh";
            btn_Refresh.Size = new Size(150, 46);
            btn_Refresh.TabIndex = 4;
            btn_Refresh.Text = "Refresh";
            btn_Refresh.UseVisualStyleBackColor = true;
            btn_Refresh.Click += btn_Refresh_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 374);
            Controls.Add(btn_Refresh);
            Controls.Add(label1);
            Controls.Add(cmbBox_DeviceList);
            Controls.Add(lbl_Log);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "CAN Switch";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radBtn_Disconect;
        private RadioButton radBtn_Rack1;
        private RadioButton radBtn_Rack2;
        private GroupBox groupBox1;
        private RadioButton radBtn_Rack3;
        private Label lbl_Log;
        private ComboBox cmbBox_DeviceList;
        private Label label1;
        private Button btn_Refresh;
    }
}