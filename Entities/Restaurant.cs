using System.ComponentModel.DataAnnotations;
namespace OdeToFood.Entities
{
    public enum CuisineType
    {
        None,
        Italian,
        French,
        American
    }

    public class Restaurant
    {
        public int Id { get; set; }

        [RequiredAttribute, MaxLengthAttribute(50)]
        [DisplayAttribute(Name="餐廳名稱")]
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}
