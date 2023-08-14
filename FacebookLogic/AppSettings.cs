using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Logic
{
    public class AppSettings
    {
        private static readonly string r_AppSettingsFilePath = "appSettings.xml";
        public Point LastWindowLocation { get; set; }

        public Size LastWindowSize { get; set; }

        public bool RememberUser { get; set; }

        public string LastAccessToken { get; set; }

        public AppSettings()
        {
            LastWindowLocation = new Point(20, 50);
            LastWindowSize = new Size(500, 800);
            RememberUser = false;
            LastAccessToken = null;
        }

        public static AppSettings LoadFormFile()
        {
            AppSettings appSettings;

            if (File.Exists(@r_AppSettingsFilePath))
            {
                using (Stream stream = new FileStream(@r_AppSettingsFilePath, FileMode.Open))
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

            using (Stream stream = new FileStream(@r_AppSettingsFilePath, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                serializer.Serialize(stream, this);
            }
        }
    }
}
