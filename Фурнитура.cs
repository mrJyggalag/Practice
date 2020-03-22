namespace Practise
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Фурнитура
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Артикул { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string Наименование { get; set; }

        [StringLength(50)]
        public string Ширина { get; set; }

        [StringLength(50)]
        public string Длина { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Тип { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string Цена { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string Вес { get; set; }
    }
}
