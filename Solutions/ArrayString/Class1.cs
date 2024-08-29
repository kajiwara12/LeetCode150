using Azure.Storage.Blobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace ArrayString
{
    public class BlobStorage
    {
        BlobServiceClient client;
        private string x = @"";
        public BlobStorage()
        {
            client = new BlobServiceClient(@"");
        }
         public void CreateFolder(string folderName) 
          { 
                client.CreateBlobContainer("qk20202020");
          }
        public int EnumerateFolderContent(string folderName) 
        {
            var containerClienter = new BlobContainerClient(x, folderName);
            return containerClienter.GetBlobs().Count();
        }

    }
}

