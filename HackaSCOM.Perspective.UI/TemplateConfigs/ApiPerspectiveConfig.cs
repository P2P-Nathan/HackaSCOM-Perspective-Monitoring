using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace HackaSCOM.Perspective.UI.TemplateConfigs
{
    [Serializable, XmlType(AnonymousType = true), XmlRoot(Namespace = "", IsNullable = false)]
    public class ApiPerspectiveConfig
    {
        public ApiPerspectiveConfig()
        {

        }

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string AlertMessage { get; set; }

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string Operator { get; set; }

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public int WarningThreshold { get; set; }

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public int CriticalThreshold { get; set; }

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

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string Name { get; set; }

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string Description { get; set; }

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public string PerspectiveName { get; set; }

        [XmlElement(Form = XmlSchemaForm.Unqualified)]
        public int IntervalSeconds { get; set; }

    }
}
