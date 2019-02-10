using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MvcPhones.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcPhonesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcPhonesContext>>()))
            {
                //Look for any phones
                if (context.Phone.Any())
                {
                    return; // DB has been seeded
                }
                context.Phone.AddRange(
                    new Phone
                    {
                        PhoneName = "iPhone X",
                        Price = 1000,
                        Storage = 64,
                        OperatingSystem = "iOS",
                        ReleaseDate = DateTime.Parse("11-2017"),
                        Color = "Black",
                        Carrier = "Verizon"
                    },
                    new Phone
                    {
                        PhoneName = "Google Pixel 2",
                        Price = 650,
                        Storage = 64,
                        OperatingSystem = "Android",
                        ReleaseDate = DateTime.Parse("10-2017"),
                        Color = "Blue",
                        Carrier = "Sprint"
                    },
                    new Phone
                    {
                        PhoneName = "Samsung Galaxy S10",
                        Price = 1200,
                        Storage = 128,
                        OperatingSystem = "Android",
                        ReleaseDate = DateTime.Parse("02-2019"),
                        Color = "Black",
                        Carrier = "T-mobile"
                    },
                    new Phone
                    {
                        PhoneName = "iPhone 8",
                        Price = 750,
                        Storage = 256,
                        OperatingSystem = "iOS",
                        ReleaseDate = DateTime.Parse("09-2017"),
                        Color = "White",
                        Carrier = "Verizon"
                    },
                    new Phone
                    {
                        PhoneName = "Samsung Galaxy S9",
                        Price = 700,
                        Storage = 128,
                        OperatingSystem = "iOS",
                        ReleaseDate = DateTime.Parse("03-2018"),
                        Color = "Blue",
                        Carrier = "Cricket"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
