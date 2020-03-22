namespace Practise
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Заказ> Заказ { get; set; }
        public virtual DbSet<Заказанные_изделия> Заказанные_изделия { get; set; }
        public virtual DbSet<Изделия> Изделия { get; set; }
        public virtual DbSet<Пользователь> Пользователь { get; set; }
        public virtual DbSet<Склад_ткани> Склад_ткани { get; set; }
        public virtual DbSet<Склад_фурнитуры> Склад_фурнитуры { get; set; }
        public virtual DbSet<Ткани_изделия> Ткани_изделия { get; set; }
        public virtual DbSet<Фурнитура_изделия> Фурнитура_изделия { get; set; }
        public virtual DbSet<Ткани> Ткани { get; set; }
        public virtual DbSet<Фурнитура> Фурнитура { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Заказ>()
                .Property(e => e.Стоимость)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Изделия>()
                .HasMany(e => e.Заказанные_изделия)
                .WithRequired(e => e.Изделия)
                .HasForeignKey(e => e.ID_изделия)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Изделия>()
                .HasMany(e => e.Ткани_изделия)
                .WithRequired(e => e.Изделия)
                .HasForeignKey(e => e.ID_изделия)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Изделия>()
                .HasMany(e => e.Фурнитура_изделия)
                .WithRequired(e => e.Изделия)
                .HasForeignKey(e => e.ID_изделия)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Пользователь>()
                .Property(e => e.Логин)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Пользователь>()
                .Property(e => e.Пароль)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
