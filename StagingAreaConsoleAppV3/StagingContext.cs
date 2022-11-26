using StagingAreaConsoleAppV3.ArenaDataObjects;
using StagingAreaConsoleAppV3.Production;
using System;
using System.Data.Entity;
using System.Linq;


namespace StagingAreaConsoleAppV3
{
    public class StagingContext : DbContext
    {
       
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        
        public DbSet<CarPark> CarPark { get; set; }
        public DbSet<W5Booking> W5Bookings { get; set; }

        public DbSet<W5Membership> W5Memberships { get; set; }

        public DbSet<W5Sale> W5Sales { get; set; }

        public DbSet<W5SalesSummary> W5SalesSummaries { get; set; }

        public DbSet<ArenaEventAudit> ArenaEventAudits { get; set; }

        public DbSet<ArenaEventCapacity> ArenaEventCapacities { get; set; }

        public DbSet<ArenaEventSummaryPriceLevel> ArenaEventSummaryPriceLevels { get; set; }

        public DbSet<CompType> CompTypes { get; set; }

        public DbSet<Inquiry> Inquiries { get; set; }

        public DbSet<Price> Prices { get; set; }

        public DbSet<PriceLevelDetail> PriceLeveLDetails { get; set; }

        public DbSet<PriceLevelStat> PriceLevelStats { get; set; }

        public DbSet<PriceLevelUnsold> PriceLevelUnsolds { get; set; }

        public DbSet<SalesChannelDetail> SalesChannelDetails { get; set; }

        public DbSet<Settlement> Settlements { get; set; }

        public DbSet<SummarySalesChannel> SummarySalesChannels { get; set; }

        public DbSet<SummaryTicketType> SummaryTicketTypes { get; set; }

        public DbSet<TicketTypeUnsold> TicketTypeUnsolds { get; set; }




    }

   
}