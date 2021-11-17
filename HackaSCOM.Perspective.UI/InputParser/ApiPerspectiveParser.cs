using HackaSCOM.Perspective.UI.TemplateConfigs;
using Microsoft.EnterpriseManagement.Common;
using Microsoft.EnterpriseManagement.Configuration;
using Microsoft.EnterpriseManagement.Internal.UI.Authoring.Extensibility;
using Microsoft.EnterpriseManagement.Mom.Internal.UI.Common;
using Microsoft.EnterpriseManagement.UI;
using System;
using System.ComponentModel;
using System.Xml;

namespace HackaSCOM.Perspective.UI.InputParser
{
    public class ApiPerspectiveParser : Component, IInputConfigurationParser
    {

        public ApiPerspectiveParser(IContainer parentContainer)
        {
            if (parentContainer != null)
            {
                parentContainer.Add(this);
            }
        }

        public bool LoadConfigurationXml(IPageContext pageContext)
        {
            if (pageContext == null)
            {
                throw new ArgumentNullException("pageContext");
            }
            
            var templateContext = (ITemplateContext)pageContext;
            var templateConfig = new ApiPerspectiveConfig
            {
                Name = templateContext.OutputFolder.DisplayName,
                Description = templateContext.OutputFolder.Description,
            };

            GetMonitorConfig(templateContext, ref templateConfig);
            pageContext.ConfigurationXml = XmlHelper.Serialize(templateConfig, false);
            return true;
        }

        private void GetMonitorConfig(ITemplateContext templateContext, ref ApiPerspectiveConfig templateConfig)
        {
            if (templateContext == null)
            {
                throw new ArgumentNullException("templateContext");
            }

            foreach (ManagementPackDiscovery discovery in SDKHelper.GetFolderItems<ManagementPackDiscovery>(this, templateContext.OutputFolder))
            {
                if (discovery.Name.StartsWith("HackaSCOM.ApiPerspective", StringComparison.OrdinalIgnoreCase))
                {
                    string wrappedXML = string.Format("<Configuration>{0}</Configuration>", discovery.DataSource.Configuration);
                    XmlDocument xmlConfig = new XmlDocument();
                    xmlConfig.LoadXml(wrappedXML);
                    XmlNodeList settingNodes = xmlConfig.SelectNodes("/Configuration/InstanceSettings/Settings/Setting");

                    foreach (XmlNode item in settingNodes)
                    {
                        string settingName = item.SelectSingleNode("Name").InnerText;
                        string settingValue = item.SelectSingleNode("Value").InnerText.Trim();

                        switch (settingName)
                        {
                            case "$MPElement[Name=\"System!System.Entity\"]/DisplayName$":
                                templateConfig.Name = settingValue;
                                break;
                            case "$MPElement[Name=\"HackaSCOMMonitoring!HackaSCOM.Perspective.Monitoring.ApiSimplePerspective\"]/PerspectiveName$":
                                templateConfig.PerspectiveName = settingValue;
                                break;
                            case "$MPElement[Name=\"HackaSCOMMonitoring!HackaSCOM.Perspective.Monitoring.ApiSimplePerspective\"]/Description$":
                                templateConfig.Description = settingValue;
                                break;
                            case "$MPElement[Name=\"HackaSCOMMonitoring!HackaSCOM.Perspective.Monitoring.ApiSimplePerspective\"]/AlertMessage$":
                                templateConfig.AlertMessage = settingValue;
                                break;
                            case "$MPElement[Name=\"HackaSCOMMonitoring!HackaSCOM.Perspective.Monitoring.ApiSimplePerspective\"]/Operator$":
                                templateConfig.Operator = settingValue;
                                break;
                            case "$MPElement[Name=\"HackaSCOMMonitoring!HackaSCOM.Perspective.Monitoring.ApiSimplePerspective\"]/WarningThreshold$":
                                templateConfig.WarningThreshold = int.Parse(settingValue);
                                break;
                            case "$MPElement[Name=\"HackaSCOMMonitoring!HackaSCOM.Perspective.Monitoring.ApiSimplePerspective\"]/CriticalThreshold$":
                                templateConfig.CriticalThreshold = int.Parse(settingValue);
                                break;
                            case "$MPElement[Name=\"HackaSCOMMonitoring!HackaSCOM.Perspective.Monitoring.ApiSimplePerspective\"]/IntervalSeconds$":
                                templateConfig.IntervalSeconds = int.Parse(settingValue);
                                break;
                            case "$MPElement[Name=\"HackaSCOMMonitoring!HackaSCOM.Perspective.Monitoring.ApiSimplePerspective\"]/Uri$":
                                templateConfig.Uri = settingValue;
                                break;
                            case "$MPElement[Name=\"HackaSCOMMonitoring!HackaSCOM.Perspective.Monitoring.ApiSimplePerspective\"]/Method$":
                                templateConfig.Method = settingValue;
                                break;
                            case "$MPElement[Name=\"HackaSCOMMonitoring!HackaSCOM.Perspective.Monitoring.ApiSimplePerspective\"]/Format$":
                                templateConfig.Format = settingValue;
                                break;
                            case "$MPElement[Name=\"HackaSCOMMonitoring!HackaSCOM.Perspective.Monitoring.ApiSimplePerspective\"]/ValuePath$":
                                templateConfig.ValuePath = settingValue;
                                break;
                            case "$MPElement[Name=\"HackaSCOMMonitoring!HackaSCOM.Perspective.Monitoring.ApiSimplePerspective\"]/PostBody$":
                                templateConfig.PostBody = settingValue;
                                break;
                            default:
                                break;
                        }
                    }
                    return;
                }

                throw new ObjectNotFoundException("");
            }
        }
    }
}
