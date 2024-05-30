namespace NLayer.Core
{
    public abstract class Categories:BaseEntity
    {
        public string Name { get; set; } = default!;

        public ICollection<Products> Products { get; set; } = default!; // Navigation property olarak sayılır. Çünkü içerisinde Products'a referans var.
    }
}
