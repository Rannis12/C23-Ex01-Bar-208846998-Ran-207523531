using FacebookWrapper.ObjectModel;

namespace FacebookLogic.Handlers
{
    public class StatisticsHandler
    {
        private readonly User r_LoggedInUser;
        public StatisticsHandler(User i_LoggedInUser)
        {
            r_LoggedInUser = i_LoggedInUser;
        }

        public void FetchStatistics(string i_YearSelection, out int o_PhotosCount, out int o_PostsCount, out int o_LikesCount)
        {
            int photosCount = 0;
            int postsCount = 0;
            int likesCount = 0;

            foreach (Album album in r_LoggedInUser.Albums)
            {
                foreach (Photo photo in album.Photos)
                {
                    if (photo.CreatedTime.Value.Year.ToString().Equals(i_YearSelection))
                    {
                        photosCount++;
                        likesCount += photo.LikedBy.Count;
                    }

                }
            }

            foreach (Post post in r_LoggedInUser.Posts)
            {
                if (post.CreatedTime.Value.Year.ToString().Equals(i_YearSelection))
                {
                    postsCount++;
                    //likesCount += post.LikedBy.Count;
                }
            }

            o_PhotosCount = photosCount;
            o_PostsCount = postsCount;
            o_LikesCount = likesCount;
        }
    }
}
