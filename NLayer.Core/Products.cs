using System.ComponentModel.DataAnnotations.Schema;

namespace NLayer.Core
{
    public abstract class Products:BaseEntity
    {
        public string? Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }

        public int CategoryId { get; set; } // Foreign key: Categories ile teke tek ilişki

        //[ForeignKey(nameof(CategoryId))] // Üstteki gibi isimlendirince bunu koymaya gerek kalmaz(EF Core)
        public Categories? Category { get; set; }  // Her bir Products nesnesinin bir Category'si var.
        public ProductFeatures? ProductFeature { get; set; }  // Her bir Products nesnesinin bir ProductFeature'si var.

    }
}
