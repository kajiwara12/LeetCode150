using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArrayString;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Storage.Blobs;

namespace ArrayString.Tests
{
    [TestClass()]
    public class BlobStorageTests
    {
        [TestMethod()]
        public void CreateFolderTest()
        {
            new BlobStorage().CreateFolder("qk20202020");

        }
        [TestMethod()]
        public void EnumerateFolderContentTest()
        {
            int actual = new BlobStorage().EnumerateFolderContent("images");
            Assert.AreEqual(10, actual);
        }

    }
}