using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic.Handlers
{
    public class AlbumGenerationHandler
    {
        private const int k_AmountOfPhotos = 4;
        private readonly User r_LoggedInUser;

        public AlbumGenerationHandler(User i_LoggedInUser)
        {
            r_LoggedInUser = i_LoggedInUser;
        }

        public HashSet<Photo> GenerateAlbum()
        {
            Random photoRand = new Random();
            HashSet<Photo> photos = new HashSet<Photo>();

            for (int i = 0; i < k_AmountOfPhotos; i++)
            {
                int albumIndex = generateRandomAlbumIndex();
                int photoIndex = photoRand.Next(0, r_LoggedInUser.Albums[albumIndex].Photos.Count - 1);

                while (!photos.Add(r_LoggedInUser.Albums[albumIndex].Photos[photoIndex]))
                {
                    albumIndex = generateRandomAlbumIndex();
                    photoIndex = photoRand.Next(0, r_LoggedInUser.Albums[albumIndex].Photos.Count - 1);
                }
            }

            return photos;
        }

        public bool IsUserHaveAtLeastFourPhotos()
        {
            int photosCount = 0;

            foreach (Album album in r_LoggedInUser.Albums)
            {
                photosCount += album.Photos.Count;
            }

            return photosCount >= k_AmountOfPhotos;
        }

        private int generateRandomAlbumIndex()
        {
            Random albumRand = new Random();
            int albumIndex = albumRand.Next(0, r_LoggedInUser.Albums.Count - 1);

            while (r_LoggedInUser.Albums[albumIndex].Photos.Count == 0)
            {
                albumIndex = albumRand.Next(0, r_LoggedInUser.Albums.Count - 1);
            }

            return albumIndex;
        }
    }
}
