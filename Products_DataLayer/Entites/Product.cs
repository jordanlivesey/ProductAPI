namespace Products_EF.Entites
{
    public class Product
    {
        public virtual required int Id { get; set; }
        public virtual required string Name { get; set; }
        public virtual required double Price { get; set; }
        public virtual required int Stock { get; set; }
    }
}
