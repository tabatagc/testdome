namespace TestDome
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;

    public class Folders
    {
        public static IEnumerable<string> FolderNames(string xml, char startingLetter)
        {
            return XDocument.Parse(xml).Descendants("folder")
                                       .Where(w => w.Attribute("name").Value.StartsWith(startingLetter.ToString()))
                                       .Select(s => s.Attribute("name").Value);
        }

        public static void Main(string[] args)
        {
            string xml =
                "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                "<folder name=\"c\">" +
                    "<folder name=\"program files\">" +
                        "<folder name=\"uninstall information\" />" +
                    "</folder>" +
                    "<folder name=\"users\" />" +
                "</folder>";

            foreach (string name in Folders.FolderNames(xml, 'u'))
                Console.WriteLine(name);
        }
    }
}
