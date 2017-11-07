using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Text : PresentationObject
    {
        public string FontName { get; set; }
        public int FontSize { get; set; }

        public void AddHyperlink(string url)
        {
            Console.WriteLine($"Hyperlink added to {url}");
        }

    }
}
