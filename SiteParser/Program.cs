using AngleSharp;
using Nito.AsyncEx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace SiteParser
{
    public class Program
    {
        static void Main(string[] args)
        {
            // var parser = new Parser();
            // var res = parser.GetCarModel().Result;
            // res = parser.GetCarModelCode().Result;

            AsyncContext.Run(() => Parser.GetCarInfo());
            AsyncContext.Run(() => Parser.GetCarConfig());
        }
    }
}
