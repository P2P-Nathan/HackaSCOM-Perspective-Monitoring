namespace HackaSCOM.Perspective.UI.Pages
{
    partial class UriConfigurationPage
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
            this.labelMethodLabel = new System.Windows.Forms.Label();
            this.comboBoxMethod = new System.Windows.Forms.ComboBox();
            this.labelUriAddress = new System.Windows.Forms.Label();
            this.textBoxUri = new System.Windows.Forms.TextBox();
            this.comboBoxFormat = new System.Windows.Forms.ComboBox();
            this.labelFormat = new System.Windows.Forms.Label();
            this.textBoxPostBody = new System.Windows.Forms.TextBox();
            this.labelPostBody = new System.Windows.Forms.Label();
            this.textBoxExtractionPath = new System.Windows.Forms.TextBox();
            this.labelExtraction = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMethodLabel
            // 
            this.labelMethodLabel.AutoSize = true;
            this.labelMethodLabel.Location = new System.Drawing.Point(40, 42);
            this.labelMethodLabel.Name = "labelMethodLabel";
            this.labelMethodLabel.Size = new System.Drawing.Size(101, 20);
            this.labelMethodLabel.TabIndex = 0;
            this.labelMethodLabel.Text = "Method Type";
            // 
            // comboBoxMethod
            // 
            this.comboBoxMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMethod.FormattingEnabled = true;
            this.comboBoxMethod.Items.AddRange(new object[] {
            "GET",
            "POST"});
            this.comboBoxMethod.Location = new System.Drawing.Point(46, 83);
            this.comboBoxMethod.Name = "comboBoxMethod";
            this.comboBoxMethod.Size = new System.Drawing.Size(181, 28);
            this.comboBoxMethod.TabIndex = 1;
            this.comboBoxMethod.SelectedIndexChanged += new System.EventHandler(this.comboBoxMethod_SelectedIndexChanged);
            // 
            // labelUriAddress
            // 
            this.labelUriAddress.AutoSize = true;
            this.labelUriAddress.Location = new System.Drawing.Point(42, 140);
            this.labelUriAddress.Name = "labelUriAddress";
            this.labelUriAddress.Size = new System.Drawing.Size(29, 20);
            this.labelUriAddress.TabIndex = 2;
            this.labelUriAddress.Text = "Uri";
            // 
            // textBoxUri
            // 
            this.textBoxUri.Location = new System.Drawing.Point(44, 175);
            this.textBoxUri.Name = "textBoxUri";
            this.textBoxUri.Size = new System.Drawing.Size(640, 26);
            this.textBoxUri.TabIndex = 3;
            // 
            // comboBoxFormat
            // 
            this.comboBoxFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFormat.FormattingEnabled = true;
            this.comboBoxFormat.Items.AddRange(new object[] {
            "JSON",
            "XML"});
            this.comboBoxFormat.Location = new System.Drawing.Point(353, 83);
            this.comboBoxFormat.Name = "comboBoxFormat";
            this.comboBoxFormat.Size = new System.Drawing.Size(181, 28);
            this.comboBoxFormat.TabIndex = 5;
            // 
            // labelFormat
            // 
            this.labelFormat.AutoSize = true;
            this.labelFormat.Location = new System.Drawing.Point(347, 42);
            this.labelFormat.Name = "labelFormat";
            this.labelFormat.Size = new System.Drawing.Size(137, 20);
            this.labelFormat.TabIndex = 4;
            this.labelFormat.Text = "Response Format";
            // 
            // textBoxPostBody
            // 
            this.textBoxPostBody.Location = new System.Drawing.Point(44, 342);
            this.textBoxPostBody.Multiline = true;
            this.textBoxPostBody.Name = "textBoxPostBody";
            this.textBoxPostBody.Size = new System.Drawing.Size(640, 254);
            this.textBoxPostBody.TabIndex = 7;
            // 
            // labelPostBody
            // 
            this.labelPostBody.AutoSize = true;
            this.labelPostBody.Location = new System.Drawing.Point(42, 310);
            this.labelPostBody.Name = "labelPostBody";
            this.labelPostBody.Size = new System.Drawing.Size(81, 20);
            this.labelPostBody.TabIndex = 6;
            this.labelPostBody.Text = "Post Body";
            // 
            // textBoxExtractionPath
            // 
            this.textBoxExtractionPath.Location = new System.Drawing.Point(44, 256);
            this.textBoxExtractionPath.Name = "textBoxExtractionPath";
            this.textBoxExtractionPath.Size = new System.Drawing.Size(640, 26);
            this.textBoxExtractionPath.TabIndex = 9;
            // 
            // labelExtraction
            // 
            this.labelExtraction.AutoSize = true;
            this.labelExtraction.Location = new System.Drawing.Point(42, 221);
            this.labelExtraction.Name = "labelExtraction";
            this.labelExtraction.Size = new System.Drawing.Size(117, 20);
            this.labelExtraction.TabIndex = 8;
            this.labelExtraction.Text = "Extraction Path";
            // 
            // UriConfigurationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxExtractionPath);
            this.Controls.Add(this.labelExtraction);
            this.Controls.Add(this.textBoxPostBody);
            this.Controls.Add(this.labelPostBody);
            this.Controls.Add(this.comboBoxFormat);
            this.Controls.Add(this.labelFormat);
            this.Controls.Add(this.textBoxUri);
            this.Controls.Add(this.labelUriAddress);
            this.Controls.Add(this.comboBoxMethod);
            this.Controls.Add(this.labelMethodLabel);
            this.Name = "UriConfigurationPage";
            this.NavigationText = "Uri Configuration";
            this.Size = new System.Drawing.Size(762, 699);
            this.TabName = "Uri Configuration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMethodLabel;
        private System.Windows.Forms.ComboBox comboBoxMethod;
        private System.Windows.Forms.Label labelUriAddress;
        private System.Windows.Forms.TextBox textBoxUri;
        private System.Windows.Forms.ComboBox comboBoxFormat;
        private System.Windows.Forms.Label labelFormat;
        private System.Windows.Forms.TextBox textBoxPostBody;
        private System.Windows.Forms.Label labelPostBody;
        private System.Windows.Forms.TextBox textBoxExtractionPath;
        private System.Windows.Forms.Label labelExtraction;
    }
}
