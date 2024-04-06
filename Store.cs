namespace ASP.NET
{
    public class Store
    {
        public int Id { get; set; }

        public int? ProductId { get; set; }

        public virtual Product? Product { get; set; }

        public int Quantity { get; set; }

    }
}
