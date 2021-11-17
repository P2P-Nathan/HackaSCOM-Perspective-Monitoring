using HackaSCOM.Perspective.UI.TemplateConfigs;
using Microsoft.EnterpriseManagement.Mom.Internal.UI.Common;
using Microsoft.EnterpriseManagement.UI;
using System;
using System.Windows.Forms;

namespace HackaSCOM.Perspective.UI.Pages
{
    public partial class UriConfigurationPage : UIPage
    {
        public UriConfigurationPage()
        {
            InitializeComponent();
            comboBoxFormat.SelectedIndex = 0;
            comboBoxMethod.SelectedIndex = 0;
        }

        public override void LoadPageConfig()
        {
            if (!IsCreationMode)
            {
                if (string.IsNullOrEmpty(InputConfigurationXml))
                {
                    return;
                }
                try
                {
                    UriConfigurationConfig pageConfig = XmlHelper.Deserialize(InputConfigurationXml, typeof(UriConfigurationConfig), true) as UriConfigurationConfig;
                    LoadFormData(pageConfig);

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.ToString());
                    return;
                }
            }
            IsConfigValid = true;
            base.LoadPageConfig();
        }

        public override bool SavePageConfig()
        {
            UriConfigurationConfig config = IntakeFormData();
            OutputConfigurationXml = XmlHelper.Serialize(config, true);
            return true;
        }

        private UriConfigurationConfig IntakeFormData()
        {
            UriConfigurationConfig formResults = new UriConfigurationConfig();
            formResults.Format = comboBoxFormat.Text;
            formResults.Method = comboBoxMethod.Text;
            formResults.PostBody = textBoxPostBody.Text;
            formResults.Uri = textBoxUri.Text;
            formResults.ValuePath = textBoxExtractionPath.Text;

            return formResults;
        }

        private void LoadFormData(UriConfigurationConfig pageConfig)
        {
            comboBoxFormat.Text = pageConfig.Format;
            comboBoxMethod.Text = pageConfig.Method;
            textBoxPostBody.Text = pageConfig.PostBody;
            textBoxUri.Text = pageConfig.Uri;
            textBoxExtractionPath.Text = pageConfig.ValuePath;
        }

        private void comboBoxMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelPostBody.Visible = (comboBoxMethod.Text == "POST");
            textBoxPostBody.Visible = (comboBoxMethod.Text == "POST");
        }
    }
}
