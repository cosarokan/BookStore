using EntityLayer.AbstractEntities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EntityLayer.Entities
{
    [Table("BookTypes")]
    public class BookType : Base<byte>
    {
        [Required(ErrorMessage = "Book type must not be empty!")]
        [StringLength(50)]
        public string TypeName { get; set; }
    }
}
