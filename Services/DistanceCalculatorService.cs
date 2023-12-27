using calculate_distances.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculate_distances.Services
{
    public class DistanceCalculatorService : IDistanceCalculator
    {
        private readonly string _googleMapsApiKey;

        public DistanceCalculatorService(string googleMapsApiKey)
        {
            _googleMapsApiKey = googleMapsApiKey;
        }

        public string CalculateDistance(string origin, string destination)
        {
            // Use Google Maps API to calculate distance, ensuring API key security
            // ...
            return "56";
        }
    }
}
