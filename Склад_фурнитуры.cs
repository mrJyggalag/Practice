namespace Practise
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Склад фурнитуры")]
    public partial class Склад_фурнитуры
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Партия { get; set; }

        [Key]
        [Column("Артикул фурнитуры", Order = 1)]
        public double Артикул_фурнитуры { get; set; }

        public int Количество { get; set; }
    }
}
