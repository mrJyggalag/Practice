namespace Practise
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Пользователь
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string Логин { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string Пароль { get; set; }

        [Required]
        [StringLength(50)]
        public string Роль { get; set; }

        [StringLength(50)]
        public string Наименование { get; set; }
    }
}
