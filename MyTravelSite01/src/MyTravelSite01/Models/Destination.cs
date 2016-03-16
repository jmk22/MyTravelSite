using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyTravelSite01.Models
{
    [Table("Destinations")]
    public class Destination
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
