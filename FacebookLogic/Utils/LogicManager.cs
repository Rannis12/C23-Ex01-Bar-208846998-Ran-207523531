using System.IO;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic.Utils
{
    public class LogicManager
    {
        public AppSettings AppSettings { get; private set; }
        public LoginResult LoginResult { get; private set; }
        public User LoggedInUser{ get; private set; }

        public LogicManager()
        {
            AppSettings = AppSettings.LoadFormFile();
        }

        public void Login()
        {
            LoginResult = FacebookWrapper.FacebookService.Login(
                "1038633494169557",
                "email",
                "public_profile",
                "user_age_range",
                "user_birthday",
                "user_events",
                "user_friends",
                "user_gender",
                "user_hometown",
                "user_likes",
                "user_link",
                "user_location",
                "user_photos",
                "user_posts",
                "user_videos",
                "user_friends");

            if (!string.IsNullOrEmpty(LoginResult.AccessToken))
            {
                LoggedInUser = LoginResult.LoggedInUser;
            }
        }

        public void SaveUserAccessToken()
        {
            AppSettings.SaveUserAccessToken(LoginResult.AccessToken);
        }

        public void ConnectFromXml()
        {
            LoginResult = FacebookService.Connect(AppSettings.LastAccessToken);
            LoggedInUser = LoginResult.LoggedInUser;
        }

        public void Logout()
        {
            LoginResult = null;
            LoggedInUser = null;
            AppSettings = new AppSettings();

            if(File.Exists("appSettings.xml"))
            {
                File.Delete("appSettings.xml");
            }
        }
    }
}
