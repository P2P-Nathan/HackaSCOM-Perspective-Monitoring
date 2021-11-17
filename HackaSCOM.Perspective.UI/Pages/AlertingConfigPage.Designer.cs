namespace HackaSCOM.Perspective.UI.Pages
{
    partial class AlertingConfigPage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_Critical = new System.Windows.Forms.TextBox();
            this.label_Critical = new System.Windows.Forms.Label();
            this.textBox_Warn = new System.Windows.Forms.TextBox();
            this.label_Warn = new System.Windows.Forms.Label();
            this.comboBox_ThresholdType = new System.Windows.Forms.ComboBox();
            this.textBoxAlertMessage = new System.Windows.Forms.TextBox();
            this.labelAlertMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Critical
            // 
            this.textBox_Critical.Location = new System.Drawing.Point(347, 270);
            this.textBox_Critical.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Critical.Name = "textBox_Critical";
            this.textBox_Critical.Size = new System.Drawing.Size(103, 26);
            this.textBox_Critical.TabIndex = 51;
            // 
            // label_Critical
            // 
            this.label_Critical.AutoSize = true;
            this.label_Critical.Location = new System.Drawing.Point(343, 235);
            this.label_Critical.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Critical.Name = "label_Critical";
            this.label_Critical.Size = new System.Drawing.Size(130, 20);
            this.label_Critical.TabIndex = 53;
            this.label_Critical.Text = "Critical Threshold";
            // 
            // textBox_Warn
            // 
            this.textBox_Warn.Location = new System.Drawing.Point(68, 271);
            this.textBox_Warn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Warn.Name = "textBox_Warn";
            this.textBox_Warn.Size = new System.Drawing.Size(103, 26);
            this.textBox_Warn.TabIndex = 50;
            // 
            // label_Warn
            // 
            this.label_Warn.AutoSize = true;
            this.label_Warn.Location = new System.Drawing.Point(64, 235);
            this.label_Warn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Warn.Name = "label_Warn";
            this.label_Warn.Size = new System.Drawing.Size(142, 20);
            this.label_Warn.TabIndex = 52;
            this.label_Warn.Text = "Warning Threshold";
            // 
            // comboBox_ThresholdType
            // 
            this.comboBox_ThresholdType.FormattingEnabled = true;
            this.comboBox_ThresholdType.Items.AddRange(new object[] {
            "Greater",
            "Less",
            "GreaterEqual",
            "LessEqual"});
            this.comboBox_ThresholdType.Location = new System.Drawing.Point(68, 125);
            this.comboBox_ThresholdType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_ThresholdType.Name = "comboBox_ThresholdType";
            this.comboBox_ThresholdType.Size = new System.Drawing.Size(206, 28);
            this.comboBox_ThresholdType.TabIndex = 49;
            this.comboBox_ThresholdType.Text = "Select Threshold Type";
            // 
            // textBoxAlertMessage
            // 
            this.textBoxAlertMessage.Location = new System.Drawing.Point(68, 400);
            this.textBoxAlertMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAlertMessage.Multiline = true;
            this.textBoxAlertMessage.Name = "textBoxAlertMessage";
            this.textBoxAlertMessage.Size = new System.Drawing.Size(566, 173);
            this.textBoxAlertMessage.TabIndex = 54;
            // 
            // labelAlertMessage
            // 
            this.labelAlertMessage.AutoSize = true;
            this.labelAlertMessage.Location = new System.Drawing.Point(64, 364);
            this.labelAlertMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAlertMessage.Name = "labelAlertMessage";
            this.labelAlertMessage.Size = new System.Drawing.Size(182, 20);
            this.labelAlertMessage.TabIndex = 55;
            this.labelAlertMessage.Text = "Alert Message Intro Text";
            // 
            // AlertingConfigPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxAlertMessage);
            this.Controls.Add(this.labelAlertMessage);
            this.Controls.Add(this.textBox_Critical);
            this.Controls.Add(this.label_Critical);
            this.Controls.Add(this.textBox_Warn);
            this.Controls.Add(this.label_Warn);
            this.Controls.Add(this.comboBox_ThresholdType);
            this.Name = "AlertingConfigPage";
            this.NavigationText = "Alert Configuration";
            this.TabName = "Alert Configuration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Critical;
        private System.Windows.Forms.Label label_Critical;
        private System.Windows.Forms.TextBox textBox_Warn;
        private System.Windows.Forms.Label label_Warn;
        private System.Windows.Forms.ComboBox comboBox_ThresholdType;
        private System.Windows.Forms.TextBox textBoxAlertMessage;
        private System.Windows.Forms.Label labelAlertMessage;
    }
}
