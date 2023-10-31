using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Storage
{
    internal class CompSet
    {
        public string CompHotelName;
        public int CompHotelId;
        public string CompUrl;

        public CompSet(string compHotelName, int compHotelId, string compUrl)
        {
            CompHotelName = compHotelName;
            CompHotelId = compHotelId;
            CompUrl = compUrl;
        }

    }
}
