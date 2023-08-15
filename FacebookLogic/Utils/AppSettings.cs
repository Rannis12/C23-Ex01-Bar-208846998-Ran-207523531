using System.IO;
using System.Xml.Serialization;

namespace FacebookLogic.Utils
{
    public class AppSettings
    {
        private const string k_AppSettingsFilePath = "appSettings.xml";

        public bool RememberUser { get; set; }

        public string LastAccessToken { get; set; }

        public AppSettings()
        {
            RememberUser = false;
            LastAccessToken = null;
        }

        public static AppSettings LoadFormFile()
        {
            AppSettings appSettings;

            if (File.Exists(k_AppSettingsFilePath))
            {
                using (Stream stream = new FileStream(k_AppSettingsFilePath, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    appSettings = serializer.Deserialize(stream) as AppSettings;
                }
            }
            else
            {
                appSettings = new AppSettings();
            }

            return appSettings;
        }

        public void SaveUserAccessToken(string i_LastAccessToken)
        {
            RememberUser = true;
            LastAccessToken = i_LastAccessToken;

            using (Stream stream = new FileStream(k_AppSettingsFilePath, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                serializer.Serialize(stream, this);
            }
        }
    }
}