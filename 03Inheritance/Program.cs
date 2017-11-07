using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Text text = new Text();

            text.FontName = "Verdana";
            text.FontSize = 12;
            text.AddHyperlink("www.google.com");
            text.Copy();
        }
    }
}
