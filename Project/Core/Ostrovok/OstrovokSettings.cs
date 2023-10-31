using Project.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Ostrovok
{
    internal class OstrovokSettings : IParserSettings
    {
        public string[] Url { get; set; } = new string[6] {
                "https://ostrovok.ru/hotel/russia/st._petersburg/mid7394616/ra_nevsky_44_/?q=2042&dates=01.12.2023-31.12.2023&guests=2&sid=236da8e1-1636-4b69-a1df-9450c9e4e6c2",
           
                "https://ostrovok.ru/hotel/russia/st._petersburg/mid7394597/otel_ra_tambovskaia_11/?q=2042&dates=01.12.2023-31.12.2023&guests=2&sid=236da8e1-1636-4b69-a1df-9450c9e4e6c2",
            
                "https://ostrovok.ru/hotel/russia/st._petersburg/mid6813550/ra_na_ryibinskoj_7/?q=2042&dates=01.12.2023-31.12.2023&guests=2&sid=236da8e1-1636-4b69-a1df-9450c9e4e6c2",
           
                "https://ostrovok.ru/hotel/russia/st._petersburg/mid7842297/motel/?q=2042&dates=01.12.2023-31.12.2023&guests=2&sid=236da8e1-1636-4b69-a1df-9450c9e4e6c2",
           
                "https://ostrovok.ru/hotel/russia/st._petersburg/mid7935103/hotel_esplanada/?q=2042&dates=01.12.2023-31.12.2023&guests=2&sid=236da8e1-1636-4b69-a1df-9450c9e4e6c2",
          
                "https://ostrovok.ru/hotel/russia/st._petersburg/mid7747316/bristol_hotel_2/?q=2042&dates=01.12.2023-31.12.2023&guests=2&sid=236da8e1-1636-4b69-a1df-9450c9e4e6c2"
        };
        public int GuestsAmount { get; set; }
        public int StartDays { get; set; }
        public int EndDays { get; set; }
        public int Months { get; set; }
    }
}
