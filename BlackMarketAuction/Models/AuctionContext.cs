namespace BlackMarketAuction.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    /*
         AuctionContext.cs
         Austin Cameron - Patrick Ross - Ryan Jameson
         Black Market Auction House
         This is the model context of the site.

    */

    public partial class AuctionContext : DbContext
    {
        public AuctionContext()
            : base("name=AuctionConnection")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
