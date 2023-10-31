using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Storage
{
    internal interface IParserSettings
    {
        public string[] Url { get; set; }
        public int StartDays { get; set; }
        public int EndDays { get; set; }
        public int Months { get; set; }
        public int GuestsAmount { get; set; }
    }
}
