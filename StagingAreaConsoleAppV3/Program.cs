using StagingAreaConsoleAppV3.ArenaDataObjects;
using StagingAreaConsoleAppV3.Production;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics.CodeAnalysis;
using System.IO;    
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace StagingAreaConsoleAppV3
{


    public class Program
    {

        static void Main(string[] args)
        {
            string filepath1 = "C:\\Users\\Rachael\\testData\\CarPark.csv";
            string filepath2 = "C:\\Users\\Rachael\\testData\\prepaid bookings.csv";
            string filepath3 = "C:\\Users\\Rachael\\testData\\Gamma Membership Export.csv";
            string filepath4 = "C:\\Users\\Rachael\\testData\\W5 sales report summary.csv";
            string filepath5 = "C:\\Users\\Rachael\\testData\\ticket desk sales aug 22.csv";
            string filepath6 = "C:\\Users\\Rachael\\testData\\EventAuditGeorgeEzra.csv";
            string filepath7 = "C:\\Users\\Rachael\\testData\\pricelevel.csv";
            string filepath8 = "C:\\Users\\Rachael\\testData\\capacity.csv";
            string filepath9 = "C:\\Users\\Rachael\\testData\\comps.csv";
            string filepath10 = "C:\\Users\\Rachael\\testData\\inquiry.csv";
            string filepath11 = "C:\\Users\\Rachael\\testData\\priceleveldetails.csv";
            string filepath12 = "C:\\Users\\Rachael\\testData\\pricelevelstatistics.csv";
            string filepath13 = "C:\\Users\\Rachael\\testData\\pricelevelunsold.csv";
            string filepath14 = "C:\\Users\\Rachael\\testData\\prices.csv";
            string filepath15 = "C:\\Users\\Rachael\\testData\\saleschanneldetails.csv";
            string filepath16 = "C:\\Users\\Rachael\\testData\\saleschannelsummary.csv";
            string filepath17 = "C:\\Users\\Rachael\\testData\\ticketypesummary.csv";
            string filepath18 = "C:\\Users\\Rachael\\testData\\tickettypeunsold.csv";

            ReadInCategories();
           // ReadInSubCategories();
          //  ReadCarParkFile(filepath1);
           // ReadW5BookingFile(filepath2);
            //ReadW5Memberships(filepath3);
           // ReadW5Sales(filepath4);
            //ReadW5SalesSummary(filepath5);
            //ReadArenaEventAudit(filepath6);
            //ReadArenaEventSummaryPriceLevel(filepath7);
            //ReadArenaEventCapacity(filepath8);
            //ReadCompType(filepath9);
            //ReadInquiry(filepath10);
            //ReadPriceLevelDetail(filepath11);
            //ReadPriceLevelStats(filepath12);
            //ReadPriceLevelUnsold(filepath13);
            //ReadPrices(filepath14);
            //ReadSalesChannelDetails(filepath15);
            //ReadSalesChannelSummary(filepath16);
            //ReadTicketTypeSummary(filepath17);
            //ReadTicketTypeUnsold(filepath18);

        }// end of main

        public static void ReadInCategories ()
        {
            
            Category categoryNew = new Category();
            
            using (StagingContext db = new StagingContext())
               
            {
                var categoryList = db.W5Sales.Select
                    (c => c.Catagory)


                   .ToList();
           
                var distinctList = categoryList.Distinct().ToList();
               for (int i = 0; i <distinctList.Count; i++)
                {

                    categoryNew.CategoryName = distinctList[i];
                    db.Categories.Add(categoryNew);
                    Console.WriteLine(categoryNew.CategoryName);
                  db.SaveChanges();   
                }
                
            }
             
        }
        public static void ReadInSubCategories ()
        {
            SubCategory subCategoryNew = new SubCategory();
            var distinctList = new List<string>(); 
            var SubCatArrayList = new ArrayList();
            using (var db = new StagingContext())
            {
                var subCategoryList = db.W5Sales
                    .Select(c => c.SubCatagory)

                    .ToArray();
                distinctList = subCategoryList.Distinct().ToList();

                
                    


                for (int i = 0; i < distinctList.Count; i++)
                {
                    subCategoryNew.SubCategoryName = distinctList[i];

                    string cat = db.W5Sales
                        .Where(sc => sc.SubCatagory == distinctList[i])
                        .Select(sc => sc.Catagory)
                        .ToString();
                    subCategoryNew.SubCategoryId = db.Categories

                        .Where(c => c.CategoryName == cat)
                        .Select(c => c.CategoryId)
                        .FirstOrDefault();

                    db.SubCategories.Add(subCategoryNew);


                    Console.WriteLine(subCategoryNew.SubCategoryName +"-  " + subCategoryNew.CategoryId);
                    
                    db.SaveChanges();
                }
                
            }
        }
       
        public static void ReadTicketTypeUnsold(string file)
        {
            try
            {
                using (var db = new StagingContext())
                {
                    using (StreamReader sr = new StreamReader(file))
                    {
                        sr.ReadLine();
                        while (!sr.EndOfStream)
                        {
                            long end = sr.BaseStream.Length;
                            var line = sr.ReadLine();
                            if (line.Length == 1)
                            {
                                continue;
                            }
                            if (line.Length == end)
                            {
                                break;
                            }
                            var values = line.Split(',');
                            TicketTypeUnsold ticketTypeUnsoldNew = new TicketTypeUnsold
                            {
                                TicketType = values[0],
                                Qualifier1 = values[1],
                                Qualifier2 = values[2]
                            };
                            if (int.TryParse(values[3], out int int1))
                            {
                                ticketTypeUnsoldNew.GA = int1;
                            }
                            if (int.TryParse(values[4], out int int2))
                            {
                                ticketTypeUnsoldNew.Price1 = int2;
                            }
                            if (int.TryParse(values[5], out int int3))
                            {
                                ticketTypeUnsoldNew.Price2 = int3;
                            }
                            if (int.TryParse(values[6], out int int4))
                            {
                                ticketTypeUnsoldNew.Price3 = int4;
                            }
                            if (int.TryParse(values[7], out int int5))
                            {
                                ticketTypeUnsoldNew.Disa = int5;
                            }
                            if (int.TryParse(values[8], out int int6))
                            {
                                ticketTypeUnsoldNew.SWEST = int6;
                            }
                            if (int.TryParse(values[9], out int int7))
                            {
                                ticketTypeUnsoldNew.six = int7;
                            }
                            if (int.TryParse(values[10], out int int8))
                            {
                                ticketTypeUnsoldNew.seven = int8;
                            }
                            Console.WriteLine("unsold ticket type tbl: ", ticketTypeUnsoldNew.ToString());
                            db.TicketTypeUnsolds.Add(ticketTypeUnsoldNew);
                        }
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception e)
            {
                //file not read exception
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
        public static void ReadTicketTypeSummary(string file)
        {
            try
            {
                using (var db = new StagingContext())
                {
                    using (StreamReader sr = new StreamReader(file))
                    {
                        sr.ReadLine();
                        while (!sr.EndOfStream)
                        {
                            var line = sr.ReadLine();
                            if (line.Length == 1)
                            {
                                continue;
                            }
                            var values = line.Split(',');
                            SummaryTicketType summaryTicketTypeNew = new SummaryTicketType
                            {
                                SummaryTicketName = values[0]
                            };
                            if (int.TryParse(values[1], out int int1))
                            {
                                summaryTicketTypeNew.TotalTickets = int1;
                            }
                            if (decimal.TryParse(values[2], out decimal decimal1))
                            {
                                summaryTicketTypeNew.TotalFaceValue = decimal1;
                            }
                            if (decimal.TryParse(values[3], out decimal decimal2))
                            {
                                summaryTicketTypeNew.NetCapacityPercentage = decimal2;

                            }
                            Console.WriteLine("ticket type summary tbl: ", summaryTicketTypeNew.ToString());
                            db.SummaryTicketTypes.Add(summaryTicketTypeNew);
                        }
                        db.SaveChanges();


                    }
                }
            }
            catch (Exception e)
            {
                //file not read exception
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
        public static void ReadSalesChannelSummary(string file)
        {
            try
            {
                using (var db = new StagingContext())
                {
                    using (StreamReader sr = new StreamReader(file))
                    {
                        sr.ReadLine();
                        while (!sr.EndOfStream)
                        {
                            var line = sr.ReadLine();
                            if (line.Length == 1)
                            {
                                continue;
                            }
                            var values = line.Split(',');
                            SummarySalesChannel summarySalesChannelnew = new SummarySalesChannel();
                            if (int.TryParse(values[0], out int int1))
                            {
                                summarySalesChannelnew.SummarySalesChannelId = int1;
                            }
                            summarySalesChannelnew.SummarySalesChannelName = values[1];
                            if (int.TryParse(values[2], out int int2))
                            {
                                summarySalesChannelnew.TotalTickets = int2;
                            }
                            if (decimal.TryParse(values[3], out decimal decimal1))
                            {
                                summarySalesChannelnew.TotalFaceValue = decimal1;
                            }
                            if (decimal.TryParse(values[4], out decimal decimal2))
                            {
                                summarySalesChannelnew.NetCapacityPercentage = decimal2;
                            }
                            Console.WriteLine(summarySalesChannelnew.ToString());
                        }
                    }
                }
            }
            catch (Exception e)
            {
                //file not read exception
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
        public static void ReadSalesChannelDetails(string file)
        {
            try
            {
                using (var db = new StagingContext())
                {
                    using (StreamReader sr = new StreamReader(file))
                    {
                        sr.ReadLine();
                        while (!sr.EndOfStream)
                        {
                            var line = sr.ReadLine();
                            if (line.Length == 1)
                            {
                                continue;
                            }
                            var values = line.Split(',');
                            SalesChannelDetail salesChannelDetailsnew = new SalesChannelDetail
                            {
                                SalesChannelDetailName = values[0],
                                TicketTypeName = values[1],
                                Qualifier1 = values[2],
                                Qualifier2 = values[3],
                                Qualifier3 = values[4]
                            };
                            if (int.TryParse(values[5], out int int1))
                            {
                                salesChannelDetailsnew.TotalTickets = int1;
                            }
                            if (decimal.TryParse(values[6], out decimal decimal1))
                            {
                                salesChannelDetailsnew.TotalFaceValue = decimal1;
                            }
                            if (decimal.TryParse(values[7], out decimal decimal2))
                            {
                                salesChannelDetailsnew.NetCapacityPercentage = decimal2;
                            }
                            if (int.TryParse(values[8], out int int2))
                            {
                                salesChannelDetailsnew.GA = int2;
                            }
                            if (int.TryParse(values[9], out int int3))
                            {
                                salesChannelDetailsnew.Price1 = int3;
                            }
                            if (int.TryParse(values[10], out int int4))
                            {
                                salesChannelDetailsnew.Price2 = int4;
                            }
                            if (int.TryParse(values[11], out int int5))
                            {
                                salesChannelDetailsnew.Price3 = int5;
                            }
                            if (int.TryParse(values[12], out int int6))
                            {
                                salesChannelDetailsnew.Disa = int6;
                            }
                            if (int.TryParse(values[13], out int int7))
                            {
                                salesChannelDetailsnew.SWest = int7;
                            }
                            Console.WriteLine("sale channel detail tbl: ", salesChannelDetailsnew.ToString());
                            db.SalesChannelDetails.Add(salesChannelDetailsnew);
                        }
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception e)
            {
                //file not read exception
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }

        public static void ReadPrices(string file)
        {
            try
            {
                using (var db = new StagingContext())
                {
                    using (StreamReader sr = new StreamReader(file))
                    {
                        sr.ReadLine();
                        while (!sr.EndOfStream)
                        {
                            var line = sr.ReadLine();
                            if (line.Length == 1)
                            {
                                continue;
                            }
                            var values = line.Split(',');
                            Price pricesNew = new Price
                            {
                                TicketType = values[0],
                                Qualifier = values[1]
                            };
                            if (int.TryParse(values[3], out int int1))
                            {
                                pricesNew.GA = int1;
                            }
                            if (int.TryParse(values[4], out int int2))
                            {
                                pricesNew.Price1 = int2;
                            }
                            if (int.TryParse(values[5], out int int3))
                            {
                                pricesNew.Price2 = int3;
                            }
                            if (int.TryParse(values[6], out int int4))
                            {
                                pricesNew.Price3 = int4;
                            }
                            if (int.TryParse(values[7], out int int5))
                            {
                                pricesNew.Disa = int5;
                            }
                            if (int.TryParse(values[8], out int int6))
                            {
                                pricesNew.SWEST = int6;
                            }
                            if (int.TryParse(values[9], out int int7))
                            {
                                pricesNew.six = int7;
                            }
                            if (int.TryParse(values[10], out int int8))
                            {
                                pricesNew.seven = int8;
                            }
                            Console.WriteLine("price table: ", pricesNew.PriceId);
                            db.Prices.Add(pricesNew);
                        }
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception e)
            {
                //file not read exception
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
        public static void ReadPriceLevelUnsold(string file)
        {
            try
            {
                using (var db = new StagingContext())
                {
                    using (StreamReader sr = new StreamReader(file))
                    {
                        sr.ReadLine();
                        while (!sr.EndOfStream)
                        {
                            var line = sr.ReadLine();
                            if (line.Length == 1)
                            {
                                continue;
                            }
                            var values = line.Split(',');
                            PriceLevelUnsold priceLevelUnsoldnew = new PriceLevelUnsold();
                            if (int.TryParse(values[0], out int int1))
                            {
                                priceLevelUnsoldnew.PriceLevelUnsoldId = int1;
                            }
                            priceLevelUnsoldnew.Price = values[1];
                            priceLevelUnsoldnew.TicketType = values[2];
                            priceLevelUnsoldnew.Qualifier1 = values[3];
                            priceLevelUnsoldnew.Qualifier2 = values[4];
                            priceLevelUnsoldnew.Qualifier3 = values[5];
                            if (int.TryParse(values[6], out int int2))
                            {
                                priceLevelUnsoldnew.TotalUnsold = int2;
                            }
                            if (decimal.TryParse(values[7], out decimal decimal1))
                            {
                                priceLevelUnsoldnew.NetCapacityPercent = decimal1;
                            }
                            Console.WriteLine(priceLevelUnsoldnew.ToString());
                            db.PriceLevelUnsolds.Add(priceLevelUnsoldnew);
                        }
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception e)
            {
                //file not read exception
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
        public static void ReadPriceLevelStats(string file)
        {
            try
            {

                using (var db = new StagingContext())
                {
                    using (StreamReader sr = new StreamReader(file))
                    {
                        sr.ReadLine();
                        while (!sr.EndOfStream)
                        {
                            var line = sr.ReadLine();
                            if (line.Length == 1)
                            {
                                continue;
                            }
                            var values = line.Split(',');
                            PriceLevelStat priceLevelStatsnew = new PriceLevelStat
                            {
                                PriceLevel = values[0]
                            };
                            if (decimal.TryParse(values[1], out decimal decimal1))
                            {
                                priceLevelStatsnew.Price = decimal1;
                            }
                            if (int.TryParse(values[2], out int int1))
                            {
                                priceLevelStatsnew.Sold = int1;
                            }
                            if (int.TryParse(values[3], out int int3))
                            {
                                priceLevelStatsnew.Comps = int3;
                            }
                            if (int.TryParse(values[4], out int int4))
                            {
                                priceLevelStatsnew.Opens = int4;
                            }
                            if (int.TryParse(values[5], out int int5))
                            {
                                priceLevelStatsnew.Holds = int5;
                            }
                            if (int.TryParse(values[6], out int int6))
                            {
                                priceLevelStatsnew.NetCapacity = int6;
                            }
                            if (int.TryParse(values[7], out int int7))
                            {
                                priceLevelStatsnew.SeatCapacity = int7;
                            }
                            Console.WriteLine("price level stat table: ", priceLevelStatsnew.ToString());
                            db.PriceLevelStats.Add(priceLevelStatsnew);
                        }
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception e)
            {
                //file not read exception
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
        public static void ReadPriceLevelDetail(string file)
        {
            try
            {
                using (var db = new StagingContext())
                {
                    using (StreamReader sr = new StreamReader(file))
                    {
                        sr.ReadLine();
                        while (!sr.EndOfStream)
                        {
                            var line = sr.ReadLine();
                            if (line.Length == 1)
                            {
                                continue;
                            }
                            var values = line.Split(',');
                            PriceLevelDetail priceLevelDetailsnew = new PriceLevelDetail();
                            if (int.TryParse(values[0], out int int1))
                            {
                                priceLevelDetailsnew.PricLevelDetailId = int1;
                            }
                            priceLevelDetailsnew.TicketTypeName = values[1];
                            priceLevelDetailsnew.Qualifier1 = values[2];
                            priceLevelDetailsnew.Qualifier2 = values[3];
                            priceLevelDetailsnew.Qualifier3 = values[4];
                            if (decimal.TryParse(values[5], out decimal decimal1))
                            {
                                priceLevelDetailsnew.FaceValue = decimal1;
                            }
                            if (int.TryParse(values[6], out int int2))
                            {
                                priceLevelDetailsnew.TotalTickeets = int2;
                            }
                            if (decimal.TryParse(values[5], out decimal decimal2))
                            {
                                priceLevelDetailsnew.FaceValue = decimal2;
                            }
                            if (decimal.TryParse(values[6], out decimal decimal3))
                            {
                                priceLevelDetailsnew.NetCapacityPErcentage = decimal3;
                            }
                            if (int.TryParse(values[7], out int int3))
                            {
                                priceLevelDetailsnew.AgentAssistenPhone = int3;
                            }
                            if (int.TryParse(values[8], out int int4))
                            {
                                priceLevelDetailsnew.Internet = int4;
                            }
                            if (int.TryParse(values[9], out int int5))
                            {
                                priceLevelDetailsnew.PrimaryBoxOffice = int5;
                            }
                            if (int.TryParse(values[10], out int int6))
                            {
                                priceLevelDetailsnew.SecondaryBoxOffice = int6;
                            }
                            if (int.TryParse(values[11], out int int7))
                            {
                                priceLevelDetailsnew.TAP = int7;
                            }
                            Console.WriteLine("price detial table: ", priceLevelDetailsnew.ToString());
                            db.PriceLeveLDetails.Add(priceLevelDetailsnew);
                        }
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception e)
            {
                //file not read exception
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
        public static void ReadInquiry(string file)
        {
            try
            {
                using (var db = new StagingContext())
                {
                    using (StreamReader sr = new StreamReader(file))
                    {
                        sr.ReadLine();
                        while (!sr.EndOfStream)
                        {
                            var line = sr.ReadLine();
                            if (line.Length == 1)
                            {
                                continue;
                            }
                            var values = line.Split(',');
                            Inquiry inquiryNew = new Inquiry
                            {
                                Inventory = values[0]
                            };
                            if (int.TryParse(values[1], out int int1))
                            {
                                inquiryNew.TotalTickets = int1;
                            }
                            if (int.TryParse(values[2], out int int2))
                            {
                                inquiryNew.GA = int2;
                            }
                            if (int.TryParse(values[3], out int int3))
                            {
                                inquiryNew.Price1 = int3;
                            }
                            if (int.TryParse(values[4], out int int4))
                            {
                                inquiryNew.Price2 = int4;
                            }
                            if (int.TryParse(values[5], out int int5))
                            {
                                inquiryNew.Disa = int5;
                            }
                            Console.WriteLine("inquiry table: ", inquiryNew.InquiryId);
                            db.Inquiries.Add(inquiryNew);
                        }
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception e)
            {
                //file not read exception
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
        public static void ReadCompType(string file)
        {
            try
            {
                using (var db = new StagingContext())
                {
                    using (StreamReader sr = new StreamReader(file))
                    {
                        sr.ReadLine();
                        while (!sr.EndOfStream)
                        {
                            var line = sr.ReadLine();
                            if (line.Length == 1)
                            {
                                continue;
                            }
                            var values = line.Split(',');
                            CompType compTypeNew = new CompType();
                            if (int.TryParse(values[0], out int int1))
                            {
                                compTypeNew.CompId = int1;
                            }
                            compTypeNew.CompTypeName = values[1];
                            if (int.TryParse(values[1], out int int2))
                            {
                                compTypeNew.GA = int2;
                            }
                            if (int.TryParse(values[2], out int int3))
                            {
                                compTypeNew.Price1 = int3;
                            }
                            if (int.TryParse(values[3], out int int4))
                            {
                                compTypeNew.Price2 = int4;
                            }
                            if (int.TryParse(values[4], out int int5))
                            {
                                compTypeNew.SWest = int5;
                            }
                            Console.WriteLine("comp type table: ", compTypeNew.CompId);
                            db.CompTypes.Add(compTypeNew);
                        }
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception e)
            {
                //file not read exception
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }

        public static void ReadArenaEventCapacity(string file)
        {
            try
            {
                using (var db = new StagingContext())
                {
                    using (StreamReader sr = new StreamReader(file))
                    {
                        sr.ReadLine();
                        while (!sr.EndOfStream)
                        {
                            var line = sr.ReadLine();
                            if (line.Length == 1)
                            {
                                continue;
                            }
                            var values = line.Split(',');
                            ArenaEventCapacity arenaEventCapacitynew = new ArenaEventCapacity
                            {
                                Inventory = values[0]
                            };
                            if (int.TryParse(values[1], out int int1))
                            {
                                arenaEventCapacitynew.TotalTickets = int1;
                            }
                            if (int.TryParse(values[2], out int int2))
                            {
                                arenaEventCapacitynew.GA = int2;
                            }
                            if (int.TryParse(values[3], out int int3))
                            {
                                arenaEventCapacitynew.Price1 = int3;
                            }
                            if (int.TryParse(values[4], out int int4))
                            {
                                arenaEventCapacitynew.Price1 = int4;
                            }
                            Console.WriteLine("Capacity table: ", arenaEventCapacitynew.ToString());
                            db.ArenaEventCapacities.Add(arenaEventCapacitynew);
                        }
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception e)
            {
                //file not read exception
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
        public static void ReadArenaEventSummaryPriceLevel(string file)
        {
            try
            {
                using (var db = new StagingContext())
                {
                    using (StreamReader sr = new StreamReader(file))
                    {
                        sr.ReadLine();
                        while (!sr.EndOfStream)
                        {
                            var line = sr.ReadLine();
                            if (line.Length == 1)
                            {
                                continue;
                            }
                            var values = line.Split(',');
                            ArenaEventSummaryPriceLevel arenaEventSummaryPriceLevelnew = new ArenaEventSummaryPriceLevel
                            {
                                PriceLevelName = values[0]
                            };
                            if (int.TryParse(values[1], out int int1))
                            {
                                arenaEventSummaryPriceLevelnew.NetCapacity = int1;
                            }
                            if (int.TryParse(values[2], out int int2))
                            {
                                arenaEventSummaryPriceLevelnew.TotalTickets = int2;
                            }
                            if (decimal.TryParse(values[3], out decimal decimal1))
                            {
                                arenaEventSummaryPriceLevelnew.TotalFaceValue = decimal1;
                            }
                            if (decimal.TryParse(values[4], out decimal decimal2))
                            {
                                arenaEventSummaryPriceLevelnew.PercentDistributed = decimal2;
                            }
                            if (decimal.TryParse(values[5], out decimal decimal3))
                            {
                                arenaEventSummaryPriceLevelnew.PercentNetCapacity = decimal3;
                            }
                            if (decimal.TryParse(values[6], out decimal decimal4))
                            {
                                arenaEventSummaryPriceLevelnew.RetailAvailibiltyPercent = decimal4;
                            }
                            Console.WriteLine("arena event summary: ",arenaEventSummaryPriceLevelnew.ToString());
                            db.ArenaEventSummaryPriceLevels.Add(arenaEventSummaryPriceLevelnew);
                        }
                        db.SaveChanges();
                    }
                }

            }
            catch (Exception e)
            {
                //file not read exception
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

        }
        public static void ReadArenaEventAudit(string file)
        {
            try
            {
                using (var db = new StagingContext())
                {
                    using (StreamReader sr = new StreamReader(file))
                    {
                        sr.ReadLine();
                        while (!sr.EndOfStream)
                        {
                            var line = sr.ReadLine();
                            if (line.Length == 1)
                            {
                                continue;
                            }
                            var values = line.Split(',');
                            ArenaEventAudit arenaEventAuditnew = new ArenaEventAudit
                            {
                                EventTitle = values[0],
                                EventCode = values[1]
                            };
                            if (DateTime.TryParse(values[2], out DateTime dateTime1))
                            {
                                arenaEventAuditnew.DataAsAt = dateTime1;
                            }
                            if (int.TryParse(values[3], out int int1))
                            {
                                arenaEventAuditnew.TotalTickets = int1;
                            }
                            if (int.TryParse(values[4], out int int2))
                            {
                                arenaEventAuditnew.NetCapacity = int2;
                            }
                            if (decimal.TryParse(values[4], out decimal decimal1))
                            {
                                arenaEventAuditnew.RetailAvailability = decimal1;
                            }
                            if (decimal.TryParse(values[5], out decimal decimal2))
                            {
                                arenaEventAuditnew.TotalFaceValue = decimal2;
                            }
                            if (decimal.TryParse(values[5], out decimal decimal3))
                            {
                                arenaEventAuditnew.Potential = decimal3;
                            }
                            if (int.TryParse(values[6], out int int3))
                            {
                                arenaEventAuditnew.Sold = int3;
                            }
                            if (decimal.TryParse(values[7], out decimal decimal4))
                            {
                                arenaEventAuditnew.SoldPercentage = decimal4;
                            }
                            if (int.TryParse(values[8], out int int4))
                            {
                                arenaEventAuditnew.Comps = int4;
                            }
                            if (decimal.TryParse(values[8], out decimal decimal5))
                            {
                                arenaEventAuditnew.CompsPercentage = decimal5;
                            }
                            if (int.TryParse(values[9], out int int5))
                            {
                                arenaEventAuditnew.PrePrints = int5;
                            }
                            if (decimal.TryParse(values[10], out decimal decimal6))
                            {
                                arenaEventAuditnew.PrePrintsPercentage = decimal6;
                            }
                            if (int.TryParse(values[11], out int int6))
                            {
                                arenaEventAuditnew.Holds = int6;
                            }
                            if (decimal.TryParse(values[12], out decimal decimal7))
                            {
                                arenaEventAuditnew.HoldsPercentage = decimal7;
                            }
                            if (int.TryParse(values[13], out int int7))
                            {
                                arenaEventAuditnew.Opens = int7;
                            }
                            if (decimal.TryParse(values[14], out decimal decimal8))
                            {
                                arenaEventAuditnew.OpensPercentage = decimal8;
                            }
                            if (int.TryParse(values[15], out int int8))
                            {
                                arenaEventAuditnew.Inquiry = int8;
                            }
                            if (decimal.TryParse(values[16], out decimal decimal9))
                            {
                                arenaEventAuditnew.InquiryPercentage = decimal9;
                            }
                            if (int.TryParse(values[17], out int int9))
                            {
                                arenaEventAuditnew.TotalTicketsSoldToday = int9;
                            }
                            if (decimal.TryParse(values[18], out decimal decimal10))
                            {
                                arenaEventAuditnew.TotalFaceValueToday = decimal10;
                            }
                            Console.WriteLine("aren event table: ", arenaEventAuditnew.ArenaEventAuditId);

                            db.ArenaEventAudits.Add(arenaEventAuditnew);
                            
                        }
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception e)
            {
                //file not read exception
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
        public static void ReadW5SalesSummary(string file)
        {
            try
            {
                using (var db = new StagingContext())
                {

                    using (StreamReader sr = new StreamReader(file))
                    {
                        sr.ReadLine();
                        while (!sr.EndOfStream)
                        {
                            var line = sr.ReadLine();
                            if (line.Length == 1)
                            {
                                continue;
                            }
                            var values = line.Split(',');
                            W5SalesSummary w5SalesSummarynew = new W5SalesSummary();
                            if (int.TryParse(values[0], out int int1))
                            {
                                w5SalesSummarynew.Code = int1;
                            }
                            w5SalesSummarynew.Description = values[1];
                            if (int.TryParse(values[2], out int int2))
                            {
                                w5SalesSummarynew.Quantity = int2;
                            }
                            if (decimal.TryParse(values[3], out decimal decimal6))
                                {
                                w5SalesSummarynew.NetValue = decimal6;
                            }
                            if (decimal.TryParse(values[4], out decimal decimal1))
                            {
                                w5SalesSummarynew.VAT = decimal1;
                            }
                            if (decimal.TryParse(values[5], out decimal decimal2))
                            {
                                w5SalesSummarynew.Gross = decimal2;
                            }
                            if (decimal.TryParse(values[6], out decimal decimal7))
                            {
                                w5SalesSummarynew.Cost = decimal7;
                            }
                            if (decimal.TryParse(values[7], out decimal decimal3))
                            {
                                w5SalesSummarynew.Profit = decimal3;
                            }
                            if (decimal.TryParse(values[8], out decimal decimal4))
                            {
                                w5SalesSummarynew.Profit_Percent = decimal4;
                            }
                            Console.WriteLine("W5 sales summary: "+ w5SalesSummarynew.W5salesSummaryId);

                            db.W5SalesSummaries.Add(w5SalesSummarynew);

                        }
                        db.SaveChanges();
                    }

                }
            }
            catch (Exception e)
            {
                //file not read exception
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
        public static void ReadW5Sales(string file)
        {
            try

            {

                using (var db = new StagingContext())
                {
                    using (StreamReader sr = new StreamReader(file))
                    {
                        var i = 0;
                        sr.ReadLine();
                        while (!sr.EndOfStream)
                        {
                            var line = sr.ReadLine();
                            if (line.Length == 1)
                            {
                                continue;
                            }
                            var values = line.Split(',');
                            W5Sale w5Salesnew = new W5Sale
                            {
                                Branch = values[0]
                            };
                            if (int.TryParse(values[1], out int int1))
                            {
                                w5Salesnew.Sale_ref = int1;
                            }
                            w5Salesnew.SessionNo = values[2];
                            if (int.TryParse(values[3], out int int2))
                            {
                                w5Salesnew.TillID = int2;
                            }
                            w5Salesnew.Staff = values[4];
                            if (int.TryParse(values[5], out int int3))
                            {
                                w5Salesnew.Year = int3;
                            }
                            w5Salesnew.Month = values[6];
                            w5Salesnew.Day = values[7];
                            if (int.TryParse(values[8], out int int12))
                            {
                                w5Salesnew.Week = int12;
                            }
                            if (DateTime.TryParse(values[9], out DateTime date1))
                            {
                                w5Salesnew.Weekstart = date1;
                            }
                            string hour1 = values[10];
                            string hr = hour1.Substring(0,1);
                            Convert.ToInt16(hr);
                            if (int.TryParse(hr, out int int13))
                            {
                                w5Salesnew.Hour = int13;
                            }
                            w5Salesnew.Slot = values[11];
                            if (DateTime.TryParse(values[12], out DateTime dateTime1))
                            {
                                w5Salesnew.Tran_Date = dateTime1;
                            }
                            w5Salesnew.TranTime = values[13];
                            if (DateTime.TryParse(values[14], out DateTime date2))
                            {
                                w5Salesnew.Visit_Date = date2;
                            }
                            
                            if (int.TryParse(values[15], out int int5))
                            {
                                w5Salesnew.PLU = int5;
                            }
                            
                            w5Salesnew.privateDesc = values[16];
                            w5Salesnew.Department = values[17];
                            w5Salesnew.Catagory = values[18];
                            w5Salesnew.SubCatagory = values[19];
                            w5Salesnew.Supplier = values[20];
                            if (decimal.TryParse(values[21], out decimal decimal1))
                            {
                                w5Salesnew.cost_price = decimal1;
                            }
                            if (int.TryParse(values[22], out int int6))
                            {
                                w5Salesnew.Qty_Sold = int6;
                            }
                            if (decimal.TryParse(values[23], out decimal decimal2))
                            {
                                w5Salesnew.price_paid = decimal2;
                            }
                            if (decimal.TryParse(values[24], out decimal decimal3))
                            {
                                w5Salesnew.vatAmt = decimal3;
                            }
                            if (decimal.TryParse(values[25], out decimal decimal4))
                            {
                                w5Salesnew.Gross_line_Total = decimal4;
                            }
                            if (decimal.TryParse(values[26], out decimal decimal5))
                            {
                                w5Salesnew.Vat_line = decimal5;
                            }
                            if (decimal.TryParse(values[27], out decimal decimal6))
                            {
                                w5Salesnew.Net_line = decimal6;
                            }
                            if (char.TryParse(values[28], out char char1))
                            {
                                w5Salesnew.VatCode = char1;
                            }
                            if (int.TryParse(values[29], out int int10))
                            {
                                w5Salesnew.VatRate = int10;
                            }
                            w5Salesnew.Vat_description = values[30];
                            w5Salesnew.DiscountType = values[31];
                            w5Salesnew.VoucherName = values[32];
                            w5Salesnew.SystemDiscount_Name = values[33];
                            if (decimal.TryParse(values[34], out decimal decimal7))
                            {
                                w5Salesnew.Discount_value = decimal7;
                            }
                            if (decimal.TryParse(values[35], out decimal decimal8))
                            {
                                w5Salesnew.Selling_Price = decimal8;
                            }
                            w5Salesnew.Payment_Method = values[36];
                            if (int.TryParse(values[37], out int int7))
                            {
                                w5Salesnew.nominal = int7;
                            }
                            if (int.TryParse(values[38], out int int11))
                            {
                                w5Salesnew.PersonId = int11;
                            }
                            if (int.TryParse(values[39], out int int8))
                            {
                                w5Salesnew.Adults = int8;
                            }
                            if (int.TryParse(values[40], out int int9))
                            {
                                w5Salesnew.Children = int9;
                            }
                            w5Salesnew.Voucher_reference = values[41];
                            i++;
                            Console.WriteLine("w5 sales table: "+ i+ " "+ w5Salesnew.ToString());

                            db.W5Sales.Add(w5Salesnew);
                        }
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception e)
            {
                //file not read exception
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

        }
        public static void ReadW5Memberships(string file)
        {
            try
            {
                using (var db = new StagingContext())
                {
                    using (StreamReader sr = new StreamReader(file))
                    {
                        var i = 0;
                        sr.ReadLine();
                        while (!sr.EndOfStream)
                        {
                            var line = sr.ReadLine();
                            if (line.Length == 1)
                            {
                                continue;
                            }
                            var values = line.Split(',');
                            W5Membership w5Membershipnew = new W5Membership
                            {
                                Member_Type = values[0],
                                Membership_scheme = values[1]
                            };
                            if (int.TryParse(values[2], out int int1))
                            {
                                w5Membershipnew.Membership_number = int1;
                            }
                            if (DateTime.TryParse(values[3], out DateTime dateTime1))
                            {
                                w5Membershipnew.DateJoined = dateTime1;
                            }
                            if (DateTime.TryParse(values[4], out DateTime dateTime2))
                            {
                                w5Membershipnew.ExpiryDate = dateTime2;
                            }
                            
                            w5Membershipnew.Membership_status = values[5];
                            w5Membershipnew.Cancelled = values[6];
                            w5Membershipnew.Title = values[7];
                            w5Membershipnew.Forename = values[8];
                            w5Membershipnew.Surname = values[9];
                            w5Membershipnew.Postitle = values[10];
                            w5Membershipnew.Company_Name = values[11];
                            w5Membershipnew.HouseNo = values[12];
                            w5Membershipnew.Add1 = values[13];
                            w5Membershipnew.Add2 = values[14];
                            w5Membershipnew.Add3 = values[15];
                            w5Membershipnew.City = values[16];
                            w5Membershipnew.County = values[17];
                            w5Membershipnew.Country = values[18]; 
                            w5Membershipnew.PostCode = values[19];
                            w5Membershipnew.Tel1 = values[20];
                            w5Membershipnew.Tel2 = values[21];
                            w5Membershipnew.Email = values[22];
                            w5Membershipnew.StatusDescription = values[23];
                            w5Membershipnew.PostalConsent = values[24];
                            w5Membershipnew.PhoneConsent = values[25];
                            w5Membershipnew.EmailConsent = values[26];
                            w5Membershipnew.SMSConsent = values[27];
                            i++; 
                            Console.WriteLine("w5 member table: "+ i+ w5Membershipnew.DateJoined);

                            db.W5Memberships.Add(w5Membershipnew);

                        }
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception e)
            {
                //file not read exception
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }


        public static void ReadW5BookingFile(string file)
        {
            try
            {
                using (var db = new StagingContext())
                {
                    using (StreamReader sr = new StreamReader(file))
                    {

                        sr.ReadLine();


                        while (!sr.EndOfStream)
                        {
                            var line = sr.ReadLine();
                            if (line.Length == 1)
                            {
                                continue;
                            }
                            var values = line.Split(',');
                            W5Booking w5Bookingsnew = new W5Booking();
                            if (int.TryParse(values[0], out int int1))
                            {
                                w5Bookingsnew.W5Booking_RefId = int1;
                            }
                            w5Bookingsnew.Res_Type = values[1];
                            w5Bookingsnew.resource_name = values[2];
                            w5Bookingsnew.EventName = values[3];
                            if (DateTime.TryParse(values[4], out DateTime dateTime1))
                            {
                                w5Bookingsnew.Booked_Date = dateTime1;
                            }
                            if (DateTime.TryParse(values[5], out DateTime dateTime2))
                            {
                                w5Bookingsnew.First_Payment_Received = dateTime2;
                            }
                            if (DateTime.TryParse(values[6], out DateTime dateTime3))
                            {
                                w5Bookingsnew.Actual_Visit_Date = dateTime3;
                            }
                            if (int.TryParse(values[7], out int int7))
                            {
                                w5Bookingsnew.Actual_Visit_till_no = int7;
                            }
                            if (DateTime.TryParse(values[8], out DateTime dateTime4))
                            {
                                w5Bookingsnew.Booking_Visit_Date = dateTime4;
                            }
                            if (int.TryParse(values[9], out int int2))
                            {
                                w5Bookingsnew.Booking_ETA = int2;
                            }
                            if (decimal.TryParse(values[10], out decimal decimal1))
                            {
                                w5Bookingsnew.BookedValue = decimal1;
                            }
                            if (decimal.TryParse(values[11], out decimal decimal2))
                            {
                                w5Bookingsnew.ActualValue = decimal2;
                            }
                            if (int.TryParse(values[12], out int int3))
                            {
                                w5Bookingsnew.Booked_Child = int3;
                            }
                            if (int.TryParse(values[13], out int int4))
                            {
                                w5Bookingsnew.Actual_Child = int4;
                            }
                            if (int.TryParse(values[14], out int int5))
                            {
                                w5Bookingsnew.Booked_Adult = int5;
                            }
                            if (int.TryParse(values[15], out int int6))
                            {
                                w5Bookingsnew.Actual_Adult = int6;
                            }
                            w5Bookingsnew.Status = values[16];
                            w5Bookingsnew.Booking_Category = values[17];
                            w5Bookingsnew.Leader = values[18];
                            w5Bookingsnew.title = values[19];
                            w5Bookingsnew.forename = values[20];
                            w5Bookingsnew.surname = values[21];
                            w5Bookingsnew.email = values[22];

                            Console.WriteLine("w5 booking table: " + w5Bookingsnew.W5Booking_RefId);


                            db.W5Bookings.Add(w5Bookingsnew);
                        }
                    }
                    db.SaveChanges();


                }
            }
            catch (Exception e)
            {
                //file not read exception
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

        }

        public static void ReadCarParkFile(string file)
        {
            try
            {

                using (var db = new StagingContext())
                {
                    using (StreamReader sr = new StreamReader(file))

                    {
                        sr.ReadLine();
                        List<CarPark> carParkList = new List<CarPark>();

                        while (!sr.EndOfStream)
                        {

                            var line = sr.ReadLine();
                            if (line.Length == 1)
                            {
                                continue;
                            }
                            var values = line.Split(',');

                            CarPark carParkNew = new CarPark
                            {
                                ParkingNode = values[1],
                                TicketNumber = values[2],
                                NumberPlate = values[3],
                                MediaType = values[4]
                            };
                            if (DateTime.TryParse(values[5], out DateTime dateTime))
                            {
                                carParkNew.EntryDateTime = dateTime;
                            }
                            carParkNew.PNLaneEntryStation = values[6];
                            carParkNew.LaneEntryStation = values[7];

                            if (DateTime.TryParse(values[8], out DateTime dateTime1))
                            {
                                carParkNew.PaymentDateTime = dateTime1;
                            }
                            carParkNew.PaymentDeviceParkingNode = values[9];
                            carParkNew.PaymentDevice = values[10];
                            carParkNew.Currency = values[11];

                            if (double.TryParse(values[12], out double value))
                            {
                                carParkNew.Fee = (value);
                            }
                            if (double.TryParse(values[13], out double value1))
                            {
                                carParkNew.Validation = value1;
                            }
                            if (double.TryParse(values[14], out double value2))
                            {
                                carParkNew.Net = value2;
                            }
                            if (double.TryParse(values[15], out double value3))
                            {
                                carParkNew.Taxes = value3;
                            }
                            if (char.TryParse(values[16], out char value4))
                            {
                                carParkNew.MOP = value4;
                            }
                            carParkNew.ReceiptId = values[17];
                            if (DateTime.TryParse(values[18], out DateTime dateTime3))
                            {
                                carParkNew.ExitDateTime = dateTime3;
                            }

                            carParkNew.ParkingNodeLaneExit = values[19];
                            carParkNew.LaneExitStation = values[20];
                            if (DateTime.TryParse(values[21], out DateTime dateTime5))
                            {
                                carParkNew.StayTime = dateTime5;
                            }
                            Console.WriteLine("car park table: " + carParkNew.EntryDateTime.ToString());

                            
                            db.CarPark.Add(carParkNew);


                        }
                    }

                    db.SaveChanges();
                }

            }
            catch (Exception e)
            {
                //file not read exception
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }

    }
}// end of page
