using calculate_distances.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculate_distances.Services
{
    public class FileProcessorService : IFileProcessor
    {
        public Stream ProcessFile(Stream inputFile)
        {
            // Process Excel file, extracting pin codes and calculating distances
            // ...
            return inputFile;
        }
    }
}
