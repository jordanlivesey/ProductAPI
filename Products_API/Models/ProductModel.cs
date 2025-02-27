using Common.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Products_API.Models
{
    public class ProductModel : IRepositoryModel<int>
    {
        public required int Id { get; set; }
        [MaxLength(50)]
        public required string Name { get; set; }
        public required double Price { get; set; }
        public required int Stock { get; set; }
    }
}
