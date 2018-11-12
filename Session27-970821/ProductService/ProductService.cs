using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductService
{

    public class Product
    {
        public int productId { get; set; }
        public string productName { get; set; }
        public string productCode { get; set; }
        public string releaseDate { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public double starRating { get; set; }
        public string imageUrl { get; set; }
    }


    public class ProductService
    {
        public List<Product> GetAllProducts()
        {
            return new List<Product>()
        {
              new Product {
                productId = 1,
                productName = "Leaf Rake",
                productCode = "GDN-0011",
                releaseDate = "2017/11/11",
                description = "Leaf rake with 48-inch wooden handle.",
                price = 19.95,
                starRating = 3.2,
                imageUrl = "https://openclipart.org/image/300px/svg_to_png/26215/Anonymous_Leaf_Rake.png"
            },
            new Product {
                productId = 2,
                productName = "Garden Cart",
                productCode = "GDN-0023",
                releaseDate = "2010/05/18",
                description = "15 gallon capacity rolling garden cart",
                price = 32.99,
                starRating = 4.5,
                imageUrl = "https://openclipart.org/image/300px/svg_to_png/58471/garden_cart.png"
            },
            new Product {
                productId = 5,
                productName = "Hammer",
                productCode = "TBX-0048",
                releaseDate = "2011/06/04",
                description = "Curved claw steel hammer",
                price = 8.9,
                starRating = 4.8,
                imageUrl = "https://openclipart.org/image/300px/svg_to_png/73/rejon_Hammer.png"
            },
            new Product {
                productId = 8,
                productName = "Saw",
                productCode = "TBX-0022",
                releaseDate = "2022/10/08",
                description = "15-inch steel blade hand saw",
                price = 11.55,
                starRating = 3.7,
                imageUrl = "https://openclipart.org/image/300px/svg_to_png/27070/egore911_saw.png"
            }

        };
        }
    }
}
