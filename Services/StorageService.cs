using calculate_distances.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculate_distances.Services
{
    public class StorageService : IStorageService
    {
        private readonly string _bucketName;

        public StorageService(string bucketName)
        {
            _bucketName = bucketName;
        }

        public string  UploadFile(Stream file)
        {
            // Upload file to Cloud Storage, adhering to security best practices
            // ...
            return "done";
        }
    }
}
