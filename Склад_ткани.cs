namespace Practise
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Склад ткани")]
    public partial class Склад_ткани
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Рулон { get; set; }

        [Key]
        [Column("Артикул ткани", Order = 1)]
        public double Артикул_ткани { get; set; }

        public double? Длина { get; set; }
    }
}
