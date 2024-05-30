using System.ComponentModel.DataAnnotations;

namespace NLayer.Core
{
    // Tüm tablolarda ortak olacak özellikler BaseEntity olarak tutulur
    public abstract class BaseEntity // Abstract => newlenemez
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
