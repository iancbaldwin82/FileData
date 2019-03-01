using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FileData
{
    [TestClass]
    public class FileDataTests
    {
        [TestMethod]
        public void TestFileVersion()
        {
            //arrange
            var thirdPartyTools = new ThirdPartyTools.FileDetails();
            var filePath = "c:/test.txt";

            //assert
            Assert.IsNotNull(thirdPartyTools.Version(filePath));            
        }

        [TestMethod]
        public void TestFileSize()
        {
            //arrange
            var thirdPartyTools = new ThirdPartyTools.FileDetails();
            var filePath = "c:/test.txt";

            //assert
            Assert.IsNotNull(thirdPartyTools.Size(filePath));
        }

        [TestMethod]
        public void TestValidArgs()
        {
            //arrange            
            string[] args = { "-v", "c:\test.txt" };
            FileDataHelper.ArgType argType = FileDataHelper.ArgType.NONE;

            //assert
            Assert.IsTrue(FileData.FileDataHelper.ValidArgs(args, ref argType));
        }

        [TestMethod]
        public void TestInvalidArgs()
        {
            //arrange            
            string[] args = { "-p", "c:\test.txt" };
            FileDataHelper.ArgType argType = FileDataHelper.ArgType.NONE;

            //assert
            Assert.IsFalse(FileData.FileDataHelper.ValidArgs(args, ref argType));
        }
    }
}
