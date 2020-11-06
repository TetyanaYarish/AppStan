using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppStan.Models
{
    public class Property
    { 
   public int Id { get; set; }
    public string Title { get; set; }
        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
    public DateTime LeaseDate { get; set; }
        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
    public DateTime NowDate { get; set; }
    public string Address { get; set; }
        [Display(Name = "Price per day, $")]
        public double Price { get; set; }
    public double Sum => Price * (NowDate.Date - LeaseDate.Date).TotalDays;
        [Display(Name = "Number of Days")]
        public double Day =>  (NowDate.Date - LeaseDate.Date).TotalDays;

}
//public class PropertyDBContext : DbContext
//{
//    public DbSet<Property> Properties { get; set; }
//}
}