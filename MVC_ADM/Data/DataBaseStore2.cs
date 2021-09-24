using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_ADM.Models;

    public class DataBaseStore2 : DbContext
    {
        public DataBaseStore2 (DbContextOptions<DataBaseStore2> options)
            : base(options)
        {
        }

        public DbSet<MVC_ADM.Models.Category> Category { get; set; }

        public DbSet<MVC_ADM.Models.Order> Order { get; set; }

        public DbSet<MVC_ADM.Models.Product> Product { get; set; }

        public DbSet<MVC_ADM.Models.User> User { get; set; }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new Category() { CategoryId = 1, CategoryName = "Plantas" },
            new Category() { CategoryId = 2, CategoryName = "Flores" },
            new Category() { CategoryId = 3, CategoryName = "Produtos para cultivo" }
         );
        modelBuilder.Entity<Order>().HasData(
            new Order() { OrderId = 1, Quantity = 0, Price = 0, UserId = 1 },
            new Order() { OrderId = 2, Quantity = 0, Price = 0, UserId = 2 },
            new Order() { OrderId = 3, Quantity = 0, Price = 0, UserId = 3 },
            new Order() { OrderId = 4, Quantity = 0, Price = 0, UserId = 1 }
         );
        modelBuilder.Entity<Product>().HasData(
            new Product() { ProductId = 1, ProductName = "Philodendron Brasil", Price = 5, Amount = 1, Description = "De crescimento rápido e folha persistente, esta planta trepadeira tem o nome Brasil devido às tonalidades verde e amarela das suas folhas.", CategoryId = 1, ImgFotoProduct = "/images/PhilodendronBrasil.png" },
            new Product() { ProductId = 2, ProductName = "Monstera Deliciosa", Price = 14, Amount = 1, Description = "Com folhas grandes, verdes e em forma de coração, a Monstera deliciosa ou Costela de Adão ganha aberturas nas folhas à medida que estas amadurecem.", CategoryId = 1, ImgFotoProduct = "/images/MonsteraDeliciosa.png" },
            new Product() { ProductId = 3, ProductName = "Calathea Orbifolia", Price = 21, Amount = 1, Description = "Folhas grandes, redondas, com tonalidades verdes e listas verdes claras.", CategoryId = 1, ImgFotoProduct = "/images/CalatheaOrbifolia.png" },
            new Product() { ProductId = 4, ProductName = "Orquídea", Price = 46, Amount = 1, Description = "Florescem duas ou três vezes ao ano, precisam de muita luz, mas não luz directa, por isso, é aconselhável usar a luz do final do dia, para que floresçam e sigam radiantes.", CategoryId = 2, ImgFotoProduct = "/images/Orquidea.png" },
            new Product() { ProductId = 5, ProductName = "Margaridas Brancas", Price = 37, Amount = 1, Description = "O resultado: fusão perfeita entre pureza, jovialidade e inocência. A combinação ideal, para presentear sem nenhuma razão.", CategoryId = 2, ImgFotoProduct = "/images/MargaridasBrancas.png" },
            new Product() { ProductId = 6, ProductName = "Anthurium", Price = 45, Amount = 1, Description = "É uma planta de folhas grossas em forma de coração, vistosas e originais flores, que podem ser cor-de-rosa, brancas o amarelas... Mesmo que sem dúvida a cor estrela pelo seu contraste é o vermelho.", CategoryId = 2, ImgFotoProduct = "/images/Anthurium.png" },
            new Product() { ProductId = 7, ProductName = "Vaso Vitória", Price = 6, Amount = 1, Description = "Vaso de cerâmica vitória de qualidade superior indicado para plantas de interior.", CategoryId = 3, ImgFotoProduct = "/images/vasovitoria.png" },
            new Product() { ProductId = 8, ProductName = "Adubo Biológico Universal Líquido 780ml", Price = 7, Amount = 1, Description = "Adubo biológico universal líquido, ideal para plantas de interior e exterior.", CategoryId = 3, ImgFotoProduct = "/images/AduboBiologico.png" },
            new Product() { ProductId = 9, ProductName = "Substrato Universal Biológico 20l", Price = 6, Amount = 1, Description = "Substrato universal biológico Siro® Platina feito com matérias primas 100% sustentáveis e indicado para plantação ou transplante de plantas decorativas ou comestíveis.", CategoryId = 3, ImgFotoProduct = "/images/SubstratoUniversal.png" }

         );
        modelBuilder.Entity<User>().HasData(
            new User() { UserId = 1, AccessLevel = true, UserName = "Alexandre Couto", Birthday = "07/09/1970", PhoneNumber = "964176485", Email = "aecmar@hotmail.com", Indentification = "294260250", FiscalNumber = "294260250", Address = "Rua Vitimas da Guerra 30", PostalCode = "2825420" },
            new User() { UserId = 2, AccessLevel = true, UserName = "João Golçalves", Birthday = "22/04/2000 ", PhoneNumber = "333333333", Email = "jg@hotmail.com", Indentification = "0", FiscalNumber = "0", Address = "Rua Lisboa 40", PostalCode = "1234567" },
            new User() { UserId = 3, AccessLevel = true, UserName = "Pedro Jose", Birthday = "06/10/2005", PhoneNumber = "444444444", Email = "apjose@hotmail.com", Indentification = "0", FiscalNumber = "0", Address = "Rua Almirante reis 3", PostalCode = "7654321" }
         );
    }

}
