using System;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace HackaSCOM.Perspective.UI.TemplateConfigs
{
    [Serializable, XmlType(AnonymousType = true), XmlRoot(Namespace = "", IsNullable = false)]
    public class UriConfigurationConfig
    {
        public UriConfigurationConfig()
        {
        }

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string Uri { get; set; }

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string Method { get; set; }

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string Format { get; set; }

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string ValuePath { get; set; }

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string PostBody { get; set; }
    }
}
