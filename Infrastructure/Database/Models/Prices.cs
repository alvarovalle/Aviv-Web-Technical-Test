using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace listingapi.Infrastructure.Database.Models
{
    [Table("prices")]
    public class Prices
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("listingid")]
        public int ListingId { get; set; }
        [Column("price_eur")]
        public double PriceEur { get; set; }
        [Column("created_date")]
        public DateTimeOffset CreatedDate { get; set; }
        }
}
