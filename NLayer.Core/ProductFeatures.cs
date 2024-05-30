using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core
{
    public abstract class ProductFeatures // BaseEntity'den miras almadık. Zaten Products'un oluşma zamanları bunun da oluşma zamanıdır.
    {
        public int Id { get; set; } // BaseEntity'den miras almadık. O yüzden Id tanımlanır.
        public string? Color { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int ProductId { get; set; } // Bu da ForeignKey'dir
        public Products? Product { get; set; }
    }
}
