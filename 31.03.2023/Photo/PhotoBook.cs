namespace Photo
{
   
        public class PhotoBookTest
        {
            public static void Main()
            {
                PhotoBook myAlbum1 = new PhotoBook();
                Console.WriteLine($"The default pages: {myAlbum1.GetNumberPages()}");

                PhotoBook myAlbum2 = new PhotoBook(32);
                Console.WriteLine($"The Small PhotoBook Pages: {myAlbum2.GetNumberPages()}");

                AddPhotoBook myBigPhotoAlbum1 = new AddPhotoBook();
                Console.WriteLine($"The Big PhotoBook Pagess: {myBigPhotoAlbum1.GetNumberPages()}");

            AddPhotoBook myBigPhotoAlbum2 = new AddPhotoBook(345);
            Console.WriteLine($"The Big PhotoBook Pagess: {myBigPhotoAlbum2.GetNumberPages()}");
        }
        }

        public class PhotoBook
        {
            protected int numPages;

            public PhotoBook()
            {
                numPages = 16;
            }

            public PhotoBook(int numPages)
            {
                this.numPages = numPages;
            }

            public int GetNumberPages()
            {
                return numPages;
            }
        }

        public class AddPhotoBook : PhotoBook
        {
            public AddPhotoBook()
            {
       
                numPages = 234;
            }
        public AddPhotoBook(int numPages)
        {

            this.numPages = numPages;
        }
    }
    }
