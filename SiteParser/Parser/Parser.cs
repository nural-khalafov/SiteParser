using AngleSharp;
using AngleSharp.Common;
using AngleSharp.Dom;
using AngleSharp.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace SiteParser
{
    public class Parser
    {
        private const string MODEL_ADDRESS = "https://www.ilcats.ru/toyota/?function=getModels&market=EU";
        private const string CONFIG_ADDRESS = "https://www.ilcats.ru/toyota/?function=getComplectations&market=EU&model=671440&startDate=198308&endDate=198903";
        private const string SPAREPART_GROUP_ADDRESS = "https://www.ilcats.ru/toyota/?function=getGroups&market=EU&model=671440&modification=LN51L-KRA&complectation=001";
        private const string SPAREPART_SUBGROUP_ADDRESS = "https://www.ilcats.ru/toyota/?function=getSubGroups&market=EU&model=671440&modification=LN51L-KRA&complectation=001&group=1";
        private const string SPAREPART_ADDRESS = "https://www.ilcats.ru/toyota/?function=getSubGroups&market=EU&model=671440&modification=LN51L-KRA&complectation=001&group=1";

        public static async Task GetCarInfo() 
        {
            var config = Configuration.Default.WithDefaultLoader();
            var document = await BrowsingContext.New(config).OpenAsync(MODEL_ADDRESS);

            CarInfo carInfo = new CarInfo();

            var header = document.All.Where(m => m.LocalName == "div" &&
                                            m.HasAttribute("class") &&
                                            m.GetAttribute("class").StartsWith("Header"));

            var carModels = header.Select(m => m.TextContent);

            Console.Write("Enter the needed model from website: ");
            var modelInput = Console.ReadLine();
            var currentModel = modelInput;

            if (carModels != null) 
            {
                foreach(var model in carModels) 
                {
                    if (model == modelInput) 
                    {
                        Console.WriteLine("Current model: " + model);
                    }
                }
            }

            //var carModel = document.All.Where(m => m.LocalName == "div" &&
            //                                m.HasAttribute("class") &&
            //                                m.GetAttribute("class").StartsWith("name"));

            //var code = document.All.Where(m => m.LocalName == "div" &&
            //                                m.HasAttribute("class") &&
            //                                m.GetAttribute("class").StartsWith("id"));

            //var carProductDate = document.All.Where(m => m.LocalName == "div" && 
            //                                        m.HasAttribute("class") &&
            //                                        m.GetAttribute("class").StartsWith("dateRange"));

            //var carConfiguration = document.All.Where(m => m.LocalName == "div" &&
            //                                        m.HasAttribute("class") &&
            //                                        m.GetAttribute("class").StartsWith("modelCode"));

            //var codeSelector = "a";

            //var carcode = code.First().QuerySelector(codeSelector).TextContent;

            

            

            // entering data to class instance

            //if (carModel != null) 
            //{
            //    carInfo.ModelName = carModel.First().TextContent;
            //    Console.WriteLine("\nModel: " + carInfo.ModelName + " ");
            //} else { Console.WriteLine("Error during car model parsing"); }

            //if (carcode != null) 
            //{
            //    carInfo.ModelCode = Convert.ToInt32(carcode);
            //    Console.WriteLine("Model code: " + carInfo.ModelCode + " ");
            //} else { Console.WriteLine("Error during model code parsing"); }

            //if(carProductDate != null) 
            //{
            //    carInfo.ProductionDate = carProductDate.First().TextContent;
            //    Console.WriteLine("Model Production Date: " + carInfo.ProductionDate + " ");
            //} else { Console.WriteLine("Error during car production date parsing"); }

            //if(carConfiguration != null) 
            //{
            //    carInfo.ModelConfiguration = carConfiguration.First().TextContent;
            //    Console.WriteLine("Model Configuration: " + carInfo.ModelConfiguration + "\n");
            //} else { Console.WriteLine("Error during car configuration parsing"); }

            //if (carModel != null) 
            //{
            //    // Get current model loop
            //    foreach(var models in carModel) 
            //    {
            //        if (models.TextContent == modelInput) 
            //        {
            //            Console.WriteLine("Model: " + models.TextContent);
            //            var carIds = models.QuerySelector("div.id");

            //            Console.WriteLine(carIds.TextContent);
            //        }
            //    }
            //}

        }

        public static async Task GetCarConfig() 
        {
            var config = Configuration.Default.WithDefaultLoader();
            var document = await BrowsingContext.New(config).OpenAsync(CONFIG_ADDRESS);

            Complectation complectation = new Complectation();

            var engine = document.All.Where(m => m.LocalName == "div" &&
                                            m.HasAttribute("class") &&
                                            m.GetAttribute("class").StartsWith("01"));

            var body = document.All.Where(m => m.LocalName == "div" &&
                                            m.HasAttribute("class") &&
                                            m.GetAttribute("class").StartsWith("03"));
            
            var grade = document.All.Where(m => m.LocalName == "div" &&
                                            m.HasAttribute("class") &&
                                            m.GetAttribute("class").StartsWith("04"));
            
            var atm = document.All.Where(m => m.LocalName == "div" &&
                                            m.HasAttribute("class") &&
                                            m.GetAttribute("class").StartsWith("05"));
            
            var gearST = document.All.Where(m => m.LocalName == "div" &&
                                            m.HasAttribute("class") &&
                                            m.GetAttribute("class").StartsWith("06"));
            
            var driverPos = document.All.Where(m => m.LocalName == "div" &&
                                            m.HasAttribute("class") &&
                                            m.GetAttribute("class").StartsWith("07"));
            
            var noofDoors = document.All.Where(m => m.LocalName == "div" &&
                                            m.HasAttribute("class") &&
                                            m.GetAttribute("class").StartsWith("08"));

            var destinationOne = document.All.Where(m => m.LocalName == "div" &&
                                            m.HasAttribute("class") &&
                                            m.GetAttribute("class").StartsWith("09"));

            //if (engine != null) 
            //{
            //    complectation.Engine = engine.First().TextContent;
            //    Console.WriteLine("Engine: " + complectation.Engine + " ");
            //} else { Console.WriteLine("Error during engine parsing"); complectation.Engine = "none"; }

            //if(body != null) 
            //{
            //    complectation.Body = body.First().TextContent;
            //    Console.WriteLine("Body: " + complectation.Body + " ");
            //} else { Console.WriteLine("Error during body parsing"); complectation.Body = "none"; }

            //if(grade != null) 
            //{
            //    complectation.Grade = grade.First().TextContent;
            //    Console.WriteLine("Grade: " + complectation.Grade + " ");
            //} else { Console.WriteLine("Error during grade parsing"); complectation.Grade = "none"; }

            //if (atm != null)
            //{
            //    complectation.AtmMtm = atm.First().TextContent;
            //    Console.WriteLine("ATM,MTM: " + complectation.AtmMtm + " ");
            //} else { Console.WriteLine("Error during ATM,MTM parsing"); complectation.AtmMtm = "none"; }

            //if(gearST != null) 
            //{
            //    complectation.GearShiftType= gearST.First().TextContent;
            //    Console.WriteLine("Gear Shift Type: " + complectation.GearShiftType + " ");
            //}

            //if(driverPos != null) 
            //{
            //    complectation.DriversPosition = driverPos.First().TextContent;
            //    Console.WriteLine("Driver's position: " + complectation.DriversPosition + " ");
            //}

            //if(noofDoors != null) 
            //{
            //    complectation.NoofDoors = noofDoors.First().TextContent;
            //    Console.WriteLine("NO.OF Doors: " + complectation.NoofDoors + " ");
            //}

            //if(destinationOne != null) 
            //{
            //    complectation.DestinationOne = destinationOne.First().TextContent;
            //    Console.WriteLine("Destination 1: " + complectation.DestinationOne + " ");
            //}
        }

        /// <summary>
        /// Insert data to DB
        /// </summary>
        public void InsertCarInfo() 
        {
        }
    }
}
