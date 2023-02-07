using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ViewProtectedFiles.Tests
{
    [TestClass]
    public class SessionTests
    {
        [TestMethod]
        public void GetLastDirectoryPathTest()
        {
            // arrange
            string path = @"C:\Folder\NewFolder\";
            string expected = @"C:\Folder\";

            // act
            string actual = Session.GetLastDirectoryPath(path);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetDirectoryNameTest()
        {
            // arrange
            string path = @"C:\Folder\NewFolder\";
            string expected = "NewFolder";

            // act
            string actual = Session.GetDirectoryName(path);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
