using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Sense_Configurator
{
    public class XML
    {

        public static void write(string xmlFileName, string xmlRoot, string xmlCatagory, string xmlSetting, string xmlValue)
        {
            XmlWriterSettings xws = new XmlWriterSettings();
            xws.OmitXmlDeclaration = true;
            xws.Indent = true;

            using (XmlWriter xw = XmlWriter.Create(xmlFileName,xws))
            {
                xw.WriteStartElement(xmlRoot);

                XElement child1 = new XElement(xmlCatagory, new XElement(xmlSetting, xmlValue));
                child1.WriteTo(xw);

                xw.WriteEndElement();
            }
        }

        public static void read(string xmlFileName, string xmlRoot, string xmlCatagory, string xmlSetting)
        {
            Logger.WriteLog("log.txt", "class XML read: " + xmlFileName + " " + xmlRoot + " " + xmlCatagory + " " + xmlSetting);

            XElement xmlTree2 = XElement.Load(xmlFileName);

            Logger.WriteLog("log.txt", xmlTree2.ToString());

            Logger.WriteLog("log.txt",xmlTree2.Attribute("Radio").Value);

            //****************need to read attribute for element and send it to the logging program to be able to read the value from the xmnl file.
        }
    }
}
