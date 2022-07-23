using System.Xml.Serialization;

namespace Tracker.Infraestructure
{
    public class Configuration
    {
        private string _path;

        public Configuration()
        {
            _path = Directory.GetCurrentDirectory() + "\\settings.xml";
        }

        public SettingsXml LoadSettings()
        {
            try
            {
                var xmlDocument = File.ReadAllText(_path);

                var serializer = new XmlSerializer(typeof(SettingsXml));

                SettingsXml settings = new();

                using (TextReader reader = new StringReader(xmlDocument))
                {
                    settings = (SettingsXml)serializer.Deserialize(reader);
                }

                return settings;
            }
            catch
            {
                return new SettingsXml();
            }
        }

        public void Save(SettingsXml settings)
        {
            try
            {
                XmlSerializer x = new(typeof(SettingsXml));
                using (TextWriter writer = new StreamWriter(_path))
                {
                    x.Serialize(writer, settings);
                }
            }
            catch (IOException)
            {
                Thread.Sleep(1500);

                XmlSerializer x = new(typeof(SettingsXml));
                using (TextWriter writer = new StreamWriter(_path))
                {
                    x.Serialize(writer, settings);
                }
            }
        }
    }
}
