using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteParser
{
    public class CarInfo
    {
        public string ModelName { get; set; }
        public List<string> ModelCode { get; set; } = new List<string>();
        public string ProductionDate { get; set; }
        public string ModelConfiguration { get; set; }

        public CarInfo()
        {

        }
    }
}
