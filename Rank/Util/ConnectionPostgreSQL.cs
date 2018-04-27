using System.IO;
using System.Xml;
using Npgsql;

namespace Rank.Util
{
    public class ConnectionPostgreSQL
    {
        public string server;
        public string port;
        public string user;
        public string pswd;
        public string db;
        private const string path = "C:\\opt\\config_rank.xml";

        public NpgsqlConnection OpenConnection()
        {

            if (!File.Exists(path)) { CreateNewXml(path); }
            else { ReadXml(path); }

            NpgsqlConnection connection = new NpgsqlConnection();
            var stringConnection = "Server=" + server + "; Port=" + port + "; User ID=" + user + "; Password=" + pswd + "; Database=" + db + ";";
            if (!string.IsNullOrWhiteSpace(stringConnection))
            {
                try
                {
                    connection = new NpgsqlConnection(stringConnection);
                    connection.Open();
                }
                catch { connection.Close(); }
            }
            return connection;
        }

        public void ReadXml(string path)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(path);

            XmlNodeList xmlList = xmlDocument.SelectNodes("connections/connection");
            XmlNode xmlNode = xmlList.Item(xmlList.Count - 1);

            server = xmlNode.SelectSingleNode("server").InnerText;
            port = xmlNode.SelectSingleNode("port").InnerText;
            user = xmlNode.SelectSingleNode("user").InnerText;
            pswd = xmlNode.SelectSingleNode("pswd").InnerText;
            db = xmlNode.SelectSingleNode("db").InnerText;
        }

        public void UpdateConnection(NpgsqlConnection connection, string serverLocal, string portLocal, string userLocal, string passLocal, string dbLocal)
        {
            connection.Close();
            server = serverLocal;
            port = portLocal;
            user = userLocal;
            pswd = passLocal;
            db = dbLocal;

            DataConnection(server, port, user, pswd, db, path);
            OpenConnection();
        }

        public void CreateNewXml(string path)
        {
            server = "127.0.0.1";
            port = "5432";
            user = "postgres";
            pswd = "123456";
            db = "bd_rank";

            DataConnection(server, port, user, pswd, db, path);
        }

        public void DataConnection(string server, string port, string user, string pswd, string db, string path)
        {
            XmlDocument xmlDocument = new XmlDocument();

            XmlDeclaration xmlDeclaration = xmlDocument.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlElement root = xmlDocument.DocumentElement;
            xmlDocument.InsertBefore(xmlDeclaration, root);

            XmlElement xmlConn = xmlDocument.CreateElement(string.Empty, "connections", string.Empty);
            xmlDocument.AppendChild(xmlConn);

            XmlElement connections = xmlDocument.CreateElement(string.Empty, "connection", string.Empty);
            xmlConn.AppendChild(connections);

            XmlElement serverElement = xmlDocument.CreateElement(string.Empty, "server", string.Empty);
            XmlText txtServer = xmlDocument.CreateTextNode(server);
            serverElement.AppendChild(txtServer);
            connections.AppendChild(serverElement);

            XmlElement portElement = xmlDocument.CreateElement(string.Empty, "port", string.Empty);
            XmlText txtPort = xmlDocument.CreateTextNode(port);
            portElement.AppendChild(txtPort);
            connections.AppendChild(portElement);

            XmlElement userElement = xmlDocument.CreateElement(string.Empty, "user", string.Empty);
            XmlText txtUser = xmlDocument.CreateTextNode(user);
            userElement.AppendChild(txtUser);
            connections.AppendChild(userElement);

            XmlElement pswdElement = xmlDocument.CreateElement(string.Empty, "pswd", string.Empty);
            XmlText txtPswd = xmlDocument.CreateTextNode(pswd);
            pswdElement.AppendChild(txtPswd);
            connections.AppendChild(pswdElement);

            XmlElement dbElement = xmlDocument.CreateElement(string.Empty, "db", string.Empty);
            XmlText txtDb = xmlDocument.CreateTextNode(db);
            dbElement.AppendChild(txtDb);
            connections.AppendChild(dbElement);

            xmlDocument.Save(path);
        }
    }
}