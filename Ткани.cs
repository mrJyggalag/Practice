namespace Practise
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ткани
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Артикул { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Название { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Цвет { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string Рисунок { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string Состав { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string Ширина { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string Длина { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(50)]
        public string Цена { get; set; }
    }
}
