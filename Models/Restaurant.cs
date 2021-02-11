using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4_DevynSmith_Section3.Models
{
    public class Restaurant
    {
        public Restaurant(int rank)
        {
            Rank = rank;
        }
        
        [Required]
        public int Rank { get; }
        [Required]
        public string RestaurantName { get; set; }
        public string? FavoriteDish { get; set; } = "It's all tasty!";
        [Required]
        public string Address { get; set; }
        [RegularExpression(@"((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}", ErrorMessage = "Phone number entered incorrectly, please use this format: 000-000-0000")]
        public string? RestaurantPhone { get; set; }
        public string? Link { get; set; } = "Coming soon";

        
        public static Restaurant[] GetRestaurants()
        {
            Restaurant r1 = new Restaurant(1)
            {
                RestaurantName = "Silver Dish Thai",
                Address = "278 W Center St Provo, UT 84601",
                RestaurantPhone = "(801)373-9540",
                Link = "https://silverdishthaicuisine.com/"
            };

            Restaurant r2 = new Restaurant(2)
            {
                RestaurantName = "WINGERS",
                FavoriteDish = "Sticky Fingers",
                Address = "1200 Towne Centre Boulevard #1096 Provo, UT 84601",
                RestaurantPhone = "(801) 812-2141",
                Link = "https://wingerbros.com/locations/goto/wingers-grill-bar-provo"
            };

            Restaurant r3 = new Restaurant(3)
            {
                RestaurantName = "Chick-fil-A",
                FavoriteDish = "Spicy Chicken Sandwich",
                Address = "484 W Bulldog Blvd, Provo, UT 84604",
                RestaurantPhone = "(801) 374-2697",
                Link = "https://www.chick-fil-a.com/locations/ut/cougar-state"
            };

            Restaurant r4 = new Restaurant(4)
            {
                RestaurantName = "Panda Express",
                FavoriteDish = "Honey Sesame Chicken",
                Address = "1240 N University Ave Provo, UT 84604",
                RestaurantPhone = "801-818-0111",
                Link = "https://www.pandaexpress.com/userlocation/724/ut/provo/1240-n-university-ave"
            };

            Restaurant r5 = new Restaurant(5)
            {
                RestaurantName = "Cafe Rio",
                FavoriteDish = "Sweet Pork Salad",
                Address = "2244 N University Pkway Provo, UT 84604",
                RestaurantPhone = "(801) 375-5133",
                Link = "https://www.caferio.com/order/provo"
            };

            return new Restaurant[] { r1, r2, r3, r4, r5 };
        }
    }
}
