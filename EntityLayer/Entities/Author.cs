using EntityLayer.AbstractEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Entities
{
    [Table("Authors")]
    public class Author : Base<int>
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Surname { get; set; }

       // [DataType(DataType.Date)]
        public DateTime? BirthDate { get; set; }

        // bir yazarın birden fazla kitabı olabilir.
        public virtual List<Book> AuthorBooks { get; set; }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }
    }
}
