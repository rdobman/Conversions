using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Conversions
{
    class OptionsDB
    {
        private const string Path = @"C:\Users\Administrator\documents\visual studio 2015\Projects\Conversions\Conversions\Content\Options.xml";

        public static List<Options> GetOptions()
        {
            List<Options> options = new List<Options>();

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;

            XmlReader xmlIn = XmlReader.Create(Path, settings);

            if (xmlIn.ReadToDescendant("Option"))
            {
                do
                {
                    Options option = new Options();
                    xmlIn.ReadStartElement("Option");
                    option.ShowToolbar = xmlIn.ReadElementContentAsString();
                    option.DefaultConversion = xmlIn.ReadElementContentAsString();

                    options.Add(option);
                }
                while (xmlIn.ReadToNextSibling("Option"));
            }
            xmlIn.Close();
            return options;
        }

        public static void SaveOptions(List<Options> options)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("    ");

            XmlWriter xmlOut = XmlWriter.Create(Path, settings);

            xmlOut.WriteStartDocument();
            xmlOut.WriteStartElement("Options");

            foreach (Options option in options)
            {
                xmlOut.WriteStartElement("Option");
                xmlOut.WriteElementString("ShowToolbar", option.ShowToolbar.ToString().ToLower());
                xmlOut.WriteElementString("DefaultConversion", option.DefaultConversion);

                xmlOut.WriteEndElement();
            }

            xmlOut.WriteEndElement();
            xmlOut.Close();
        }
    }
}
