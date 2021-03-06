// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MVC_ADM.Migrations
{
    [DbContext(typeof(DataBaseStore2))]
    partial class DataBaseStore2ModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("MVC_ADM.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Plantas"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Flores"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Produtos para cultivo"
                        });
                });

            modelBuilder.Entity("MVC_ADM.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal?>("Price")
                        .IsRequired()
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int?>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("OrderId");

                    b.HasIndex("UserId");

                    b.ToTable("Order");

                    b.HasData(
                        new
                        {
                            OrderId = 1,
                            Price = 0m,
                            Quantity = 0,
                            UserId = 1
                        },
                        new
                        {
                            OrderId = 2,
                            Price = 0m,
                            Quantity = 0,
                            UserId = 2
                        },
                        new
                        {
                            OrderId = 3,
                            Price = 0m,
                            Quantity = 0,
                            UserId = 3
                        },
                        new
                        {
                            OrderId = 4,
                            Price = 0m,
                            Quantity = 0,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("MVC_ADM.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Amount")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasMaxLength(120)
                        .HasColumnType("TEXT");

                    b.Property<string>("ImgFotoProduct")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Amount = 1,
                            CategoryId = 1,
                            Description = "De crescimento rápido e folha persistente, esta planta trepadeira tem o nome Brasil devido às tonalidades verde e amarela das suas folhas.",
                            ImgFotoProduct = "/images/PhilodendronBrasil.png",
                            Price = 5m,
                            ProductName = "Philodendron Brasil"
                        },
                        new
                        {
                            ProductId = 2,
                            Amount = 1,
                            CategoryId = 1,
                            Description = "Com folhas grandes, verdes e em forma de coração, a Monstera deliciosa ou Costela de Adão ganha aberturas nas folhas à medida que estas amadurecem.",
                            ImgFotoProduct = "/images/MonsteraDeliciosa.png",
                            Price = 14m,
                            ProductName = "Monstera Deliciosa"
                        },
                        new
                        {
                            ProductId = 3,
                            Amount = 1,
                            CategoryId = 1,
                            Description = "Folhas grandes, redondas, com tonalidades verdes e listas verdes claras.",
                            ImgFotoProduct = "/images/CalatheaOrbifolia.png",
                            Price = 21m,
                            ProductName = "Calathea Orbifolia"
                        },
                        new
                        {
                            ProductId = 4,
                            Amount = 1,
                            CategoryId = 2,
                            Description = "Florescem duas ou três vezes ao ano, precisam de muita luz, mas não luz directa, por isso, é aconselhável usar a luz do final do dia, para que floresçam e sigam radiantes.",
                            ImgFotoProduct = "/images/Orquidea.png",
                            Price = 46m,
                            ProductName = "Orquídea"
                        },
                        new
                        {
                            ProductId = 5,
                            Amount = 1,
                            CategoryId = 2,
                            Description = "O resultado: fusão perfeita entre pureza, jovialidade e inocência. A combinação ideal, para presentear sem nenhuma razão.",
                            ImgFotoProduct = "/images/MargaridasBrancas.png",
                            Price = 37m,
                            ProductName = "Margaridas Brancas"
                        },
                        new
                        {
                            ProductId = 6,
                            Amount = 1,
                            CategoryId = 2,
                            Description = "É uma planta de folhas grossas em forma de coração, vistosas e originais flores, que podem ser cor-de-rosa, brancas o amarelas... Mesmo que sem dúvida a cor estrela pelo seu contraste é o vermelho.",
                            ImgFotoProduct = "/images/Anthurium.png",
                            Price = 45m,
                            ProductName = "Anthurium"
                        },
                        new
                        {
                            ProductId = 7,
                            Amount = 1,
                            CategoryId = 3,
                            Description = "Vaso de cerâmica vitória de qualidade superior indicado para plantas de interior.",
                            ImgFotoProduct = "/images/images/vasovitoria.png",
                            Price = 6m,
                            ProductName = "Vaso Vitória"
                        },
                        new
                        {
                            ProductId = 8,
                            Amount = 1,
                            CategoryId = 3,
                            Description = "Adubo biológico universal líquido, ideal para plantas de interior e exterior.",
                            ImgFotoProduct = "/images/AduboBiologico.png",
                            Price = 7m,
                            ProductName = "Adubo Biológico Universal Líquido 780ml"
                        },
                        new
                        {
                            ProductId = 9,
                            Amount = 1,
                            CategoryId = 3,
                            Description = "Substrato universal biológico Siro® Platina feito com matérias primas 100% sustentáveis e indicado para plantação ou transplante de plantas decorativas ou comestíveis.",
                            ImgFotoProduct = "/images/SubstratoUniversal.png",
                            Price = 6m,
                            ProductName = "Substrato Universal Biológico 20l"
                        });
                });

            modelBuilder.Entity("MVC_ADM.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("AccessLevel")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("Birthday")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FiscalNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("Indentification")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("PostalCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            AccessLevel = true,
                            Address = "Rua Vitimas da Guerra 30",
                            Birthday = "07/09/1970",
                            Email = "aecmar@hotmail.com",
                            FiscalNumber = "294260250",
                            Indentification = "294260250",
                            PhoneNumber = "964176485",
                            PostalCode = "2825420",
                            UserName = "Alexandre Couto"
                        },
                        new
                        {
                            UserId = 2,
                            AccessLevel = true,
                            Address = "Rua Lisboa 40",
                            Birthday = "22/04/2000 ",
                            Email = "jg@hotmail.com",
                            FiscalNumber = "0",
                            Indentification = "0",
                            PhoneNumber = "333333333",
                            PostalCode = "1234567",
                            UserName = "João Golçalves"
                        },
                        new
                        {
                            UserId = 3,
                            AccessLevel = true,
                            Address = "Rua Almirante reis 3",
                            Birthday = "06/10/2005",
                            Email = "apjose@hotmail.com",
                            FiscalNumber = "0",
                            Indentification = "0",
                            PhoneNumber = "444444444",
                            PostalCode = "7654321",
                            UserName = "Pedro Jose"
                        });
                });

            modelBuilder.Entity("OrderProduct", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.HasKey("OrderId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderProduct");
                });

            modelBuilder.Entity("MVC_ADM.Models.Order", b =>
                {
                    b.HasOne("MVC_ADM.Models.User", "User")
                        .WithMany("Order")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MVC_ADM.Models.Product", b =>
                {
                    b.HasOne("MVC_ADM.Models.Category", "Category")
                        .WithMany("Product")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("OrderProduct", b =>
                {
                    b.HasOne("MVC_ADM.Models.Order", null)
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC_ADM.Models.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MVC_ADM.Models.Category", b =>
                {
                    b.Navigation("Product");
                });

            modelBuilder.Entity("MVC_ADM.Models.User", b =>
                {
                    b.Navigation("Order");
                });
#pragma warning restore 612, 618
        }
    }
}
