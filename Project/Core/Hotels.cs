using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Storage
{
    internal class Hotels
    {
        public string Url;
        public string RaHotels;
        public int RaHotelsID;

        public Hotels(string raHotels, int raHotelsID, string url)
        {
            RaHotels = raHotels;
            RaHotelsID = raHotelsID;
            Url = url;
        }

    }
}
