using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.AbstractEntities
{
    public abstract class Base<T> // generic
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public T Id { get; set; }

        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
