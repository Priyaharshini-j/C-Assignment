using Photo;
using System.Security.Cryptography.X509Certificates;

namespace PhotoBookTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            PhotoBook myAlbum2 = new PhotoBook(67);
            int pages = myAlbum2.GetNumberPages();
            Assert.AreEqual(67, pages);
        }
        [TestMethod]
        public void TestMethod2()
        {
            PhotoBook myAlbum2 = new PhotoBook(435);
            int pages = myAlbum2.GetNumberPages();
            Assert.AreEqual(435, pages);
        }
        [TestMethod]
        public void TestMethod3()
        {
            AddPhotoBook myBigPhotoAlbum1 = new AddPhotoBook(546);
            int pages = myBigPhotoAlbum1.GetNumberPages();
            Assert.AreEqual(435, pages);
        }
        [TestMethod]
        public void TestMethod4()
        {
            AddPhotoBook myBigPhotoAlbum1 = new AddPhotoBook(546);
            int pages = myBigPhotoAlbum1.GetNumberPages();
            Assert.AreEqual(546, pages);
        }
    }
}
