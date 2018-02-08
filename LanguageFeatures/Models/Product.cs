using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    public class Product
    {
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public Product Related { get; set; }
        // adds a default value that can be overwritten when instantiated below
        public string Category { get; set; } = "Watersports";
        // adding only get accessor makes property readonly, must be set on initialization or will goto default
        public bool? InStock { get; }
        //ctor that sets InStock bool val to true unless false is passed in as in lifejacket below
        public Product(bool stock = true)
        {
            InStock = stock;
        }

        
        //when method is called, it inits 2 product objects and returns
        //uses a collection initializer which adds elements to array in one step(even though each element is an object)
        public static Product[] GetProducts()
        {
            //using object initializer to create object and set properties in a single step instead of instatiating first then setting each prop val with dot notation
            Product kayak = new Product
            {
                Name = "Kayak",
                Category = "Water Craft",
                Price = 275M
            };
            Product lifeJacket = new Product(false)
            {
                Name = "Lifejacket",
                Price = 48.95M
            };

            kayak.Related = lifeJacket;
            return new Product[] {kayak, lifeJacket, null};
            }
        //field?property of Product class that is an array of anonymous product objects (like in a DB), since they can't be accessed by instance name, they need to be queried by Linq
        public static Product[] AnonPoductList = {
            new Product { Name = "Jeans", Category = "Clothing", Price = 24.7M },
            new Product { Name = "Socks", Category = "Clothing", Price = 8.12M },
            new Product { Name = "Scooter", Category = "Vehicle", Price = 99.99M },
            new Product { Name = "Skateboard", Category = "Vehicle", Price = 24.99M },
        };
    }
}
