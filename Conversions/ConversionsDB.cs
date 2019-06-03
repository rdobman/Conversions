using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Conversions
{
    public static class ConversionsDB
    {
        private const string ConversionsPath = @"C:\Users\Administrator\documents\visual studio 2015\Projects\Conversions\Conversions\Content\Conversions.txt";
        private const string ConversionsDefaultPath = @"C:\Users\Administrator\documents\visual studio 2015\Projects\Conversions\Conversions\Content\ConversionsDefault.txt";        

        // I know the project said Array, but since it needs to be dynamic, this made more sense.

        // I am using this to display the default conversions before saving to the .txt file using Restore button
        public static List<Conversions> GetDefaultConversions()
        {
            List<Conversions> items = new List<Conversions>();

            StreamReader textInDefault =
                    new StreamReader(new FileStream(ConversionsDefaultPath,
                    FileMode.Open, FileAccess.Read));

            while (textInDefault.Peek() != -1)
            {
                string row = textInDefault.ReadLine();
                string[] columns = row.Split('|');
                Conversions item = new Conversions();
                item.Unit1 = columns[0];
                item.Unit2 = columns[1];
                item.Multiplier = Convert.ToDouble(columns[2]);

                items.Add(item);
            }

            textInDefault.Close();

            return items;
        }

        // This is how most of the app will get the conversions list
        public static List<Conversions> GetConversions()
        {
            List<Conversions> items = new List<Conversions>();

            StreamReader textIn =
                new StreamReader(new FileStream(ConversionsPath,
                FileMode.Open, FileAccess.Read));

            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                string[] columns = row.Split('|');
                Conversions item = new Conversions();
                item.Unit1 = columns[0];
                item.Unit2 = columns[1];
                item.Multiplier = Convert.ToDouble(columns[2]);

                items.Add(item);
            }

            textIn.Close();

            if (items.Count == 0)
            {
                StreamReader textInDefault =
                    new StreamReader(new FileStream(ConversionsDefaultPath,
                    FileMode.Open, FileAccess.Read));

                while (textInDefault.Peek() != -1)
                {
                    string row = textInDefault.ReadLine();
                    string[] columns = row.Split('|');
                    Conversions item = new Conversions();
                    item.Unit1 = columns[0];
                    item.Unit2 = columns[1];
                    item.Multiplier = Convert.ToDouble(columns[2]);

                    items.Add(item);
                }

                textInDefault.Close();
            }

            

            return items;
        }

        public static void SaveConversions(List<Conversions> items)
        {
            StreamWriter textOut =
                new StreamWriter(new FileStream(ConversionsPath, FileMode.Create, FileAccess.Write));

            foreach (Conversions item in items)
            {
                textOut.Write(item.Unit1 + "|");
                textOut.Write(item.Unit2 + "|");
                textOut.Write(item.Multiplier + Environment.NewLine);
            }

            textOut.Close();
        }
    }
}
