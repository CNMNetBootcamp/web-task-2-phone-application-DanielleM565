using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcPhones.Models
{
    public class Phone
    {
        public int Id { get; set; }

        [Display(Name = "Phone Name"), StringLength(60, MinimumLength = 3)]
        public string PhoneName { get; set; } //letters and numbers

        [Column(TypeName = "decimal(18,2)"), DataType(DataType.Currency)]
        public decimal Price { get; set; } //$

        [Display(Name = "Storage Gb")]
        public int Storage { get; set; } //in gb

        [Display(Name = "Operating System")]
        public string OperatingSystem { get; set; }

        [Display(Name = "Market Release Date"), DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public string Color { get; set; }

        [Display(Name = "Mobile Carrier")]
        public string Carrier { get; set; }
    }
}
