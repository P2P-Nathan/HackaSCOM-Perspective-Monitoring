using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EnterpriseManagement.UI;
using HackaSCOM.Perspective.UI.TemplateConfigs;
using Microsoft.EnterpriseManagement.Mom.Internal.UI.Common;

namespace HackaSCOM.Perspective.UI.Pages
{
    public partial class AlertingConfigPage : UIPage
    {
        public AlertingConfigPage()
        {
            InitializeComponent();
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
                    AlertingConfig pageConfig = XmlHelper.Deserialize(InputConfigurationXml, typeof(AlertingConfig), true) as AlertingConfig;
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
            AlertingConfig config = IntakeFormData();
            OutputConfigurationXml = XmlHelper.Serialize(config, true);
            return true;
        }

        private AlertingConfig IntakeFormData()
        {
            AlertingConfig formResults = new AlertingConfig();
            formResults.AlertMessage = textBoxAlertMessage.Text;
            formResults.Operator = comboBox_ThresholdType.Text;
            formResults.WarningThreshold = int.Parse(textBox_Warn.Text);
            formResults.CriticalThreshold = int.Parse(textBox_Critical.Text);
            return formResults;
        }

        private void LoadFormData(AlertingConfig pageConfig)
        {
            textBoxAlertMessage.Text = pageConfig.AlertMessage;
            comboBox_ThresholdType.Text = pageConfig.Operator;
            textBox_Warn.Text = pageConfig.WarningThreshold.ToString();
            textBox_Critical.Text = pageConfig.CriticalThreshold.ToString();
        }
    }
}
