using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculate_distances.Interfaces
{
    public interface IFileProcessor
    {
        Stream ProcessFile(Stream inputFile);
    }
}
