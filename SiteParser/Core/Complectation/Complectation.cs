using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteParser
{
    public class Complectation
    {
        // Groups and Subgroups
        public string GroupName { get; set; }
        public string SubgroupName { get; set; }

        // Main properties
        public string Engine { get; set; }
        public string Body { get; set; }
        public string Grade { get; set; }
        public string AtmMtm { get; set; }
        public string GearShiftType { get; set; }
        public string Cab { get; set; }
        public string NoofDoors { get; set; }
        public string DriversPosition { get; set; }
        public string DestinationOne { get; set; }
        public string DestinationTwo { get; set; }
        public string ImagePath { get; set; }

        public Complectation()
        {

        }
    }
}
