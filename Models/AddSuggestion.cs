using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


//developing the model for the data, and requiring the data that is needed every time
namespace Assignment4_DevynSmith_Section3.Models
{
    public class AddSuggestionResponse
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string RestaurantName { get; set; }
        public string? FavoriteDish { get; set; }
        [RegularExpression(@"((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}", ErrorMessage = "Phone number entered incorrectly, please use this format: 000-000-0000")]
        public string? Phone { get; set; }
    }
}
