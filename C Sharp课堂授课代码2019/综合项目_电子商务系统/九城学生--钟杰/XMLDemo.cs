using System;
using System.Xml;

namespace mostone
{
    public class XMLDemo
    {
        public static string Host { get; set; }
        public static string Port { get; set; }
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static string Database { get; set; }

        public static XmlDocument xml = new XmlDocument();

        public static void ReadSqlInitXML()
        {
            string path = @"C:\Users\lyguer\Documents\Visual Studio 2010\Projects\mostone\Properties\properties.xml";
            xml.Load(path);
            XmlNode root = xml.SelectSingleNode("/MySqlInitialization");
            XmlNodeList nodes = root.ChildNodes;
            foreach (XmlNode node in nodes)
            {
                if (node.Name.Equals("host"))
                {
                    Host = node.InnerText;
                }
                else if(node.Name.Equals("port")){
                    Port = node.InnerText;
                }
                else if (node.Name.Equals("username")) 
                {
                    Username = node.InnerText;
                }
                else if (node.Name.Equals("password"))
                {
                    Password = node.InnerText;
                }
                else if (node.Name.Equals("database"))
                {
                    Database = node.InnerText;
                }
            }
        }
        
    }
}
