using OdeToFood.Entities;
using System.ComponentModel.DataAnnotations;

namespace OdeToFood.ViewModels
{
    public class RestaurantEditViewModel
    {
        [RequiredAttribute, MaxLengthAttribute(50)]
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }        
    }
}
