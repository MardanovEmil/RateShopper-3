using Project.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngleSharp.Html.Dom;
using AngleSharp;

namespace Project.Core.Ostrovok
{
     internal class PriceParser : IParser<string[]>
    {
        public string[] Parse(IHtmlDocument document) 
        {
            var list = new List<string>();
            var cellSelector = "zenroomspagerate-name-title";
            var roomsTypes = document.GetElementsByClassName(cellSelector);
            foreach ( var roomType in roomsTypes)
            {
                list.Add(roomType.TextContent);
            }

            return list.ToArray();
        }
    }

}
