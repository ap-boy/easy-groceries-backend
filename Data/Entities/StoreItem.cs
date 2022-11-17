namespace easy_groceries_backend.Data.Entities
{
    public class StoreItem
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}
