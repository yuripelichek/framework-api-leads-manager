using Framework.LeadsManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.LeadsManager.Infrastructure.Data.Context
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            #region Include Client
            modelBuilder.Entity<Client>().HasData(
                        new Client
                        {
                            Id = -6,
                            Name = "Nome01",
                            LastName = "Sobrenome01",
                            Phone = "111.000.000",
                            Email = "nome01@xyz.com",
                            CreatedAt = DateTime.Now,
                            ModifiedAt = DateTime.Now
                        },
                        new Client
                        {
                            Id = -2,
                            Name = "Nome022",
                            LastName = "Sobrenome022",
                            Phone = "222222.000.000",
                            Email = "nome022@xyz.com",
                            CreatedAt = DateTime.Now,
                            ModifiedAt = DateTime.Now
                        },
                        new Client
                        {
                            Id = -3,
                            Name = "Nome033",
                            LastName = "Sobrenome033",
                            Phone = "333333.000.000",
                            Email = "nome033@xyz.com",
                            CreatedAt = DateTime.Now,
                            ModifiedAt = DateTime.Now
                        },
                        new Client
                        {
                            Id = -4,
                            Name = "Nome044",
                            LastName = "Sobrenome044",
                            Phone = "444444.000.000",
                            Email = "nome044@xyz.com",
                            CreatedAt = DateTime.Now,
                            ModifiedAt = DateTime.Now
                        },
                        new Client
                        {
                            Id = -5,
                            Name = "Nome055",
                            LastName = "Sobrenome044",
                            Phone = "444444.000.000",
                            Email = "nome044@xyz.com",
                            CreatedAt = DateTime.Now,
                            ModifiedAt = DateTime.Now
                        }
                    );
            #endregion

            #region Include Category
            modelBuilder.Entity<Category>().HasData(
                        new Category
                        {
                            Id = -1,
                            Name = "Categoria01",
                            Description = "CategoriaDescription01",
                            CreatedAt = DateTime.Now,
                            ModifiedAt = DateTime.Now
                        },
                        new Category
                        {
                            Id = -2,
                            Name = "Categoria02",
                            Description = "CategoriaDescription02",
                            CreatedAt = DateTime.Now,
                            ModifiedAt = DateTime.Now
                        },
                        new Category
                        {
                            Id = -3,
                            Name = "Categoria03",
                            Description = "CategoriaDescription03",
                            CreatedAt = DateTime.Now,
                            ModifiedAt = DateTime.Now
                        },
                        new Category
                        {
                            Id = -4,
                            Name = "Categoria04",
                            Description = "CategoriaDescription04",
                            CreatedAt = DateTime.Now,
                            ModifiedAt = DateTime.Now
                        }
                    );
            #endregion

            #region Include Address
            modelBuilder.Entity<Address>().HasData(
                        new Address
                        {
                            Id = -1,
                            ClientId = -6,
                            City = "City01",
                            Complement = "",
                            Neighborhood = "Bairro01",
                            Number = "001",
                            State = "",
                            Street = "",
                            ZipCode = "",
                            CreatedAt = DateTime.Now,
                            ModifiedAt = DateTime.Now
                        },
                        new Address
                        {
                            Id = -2,
                            ClientId = -2,
                            City = "City01",
                            Complement = "",
                            Neighborhood = "Bairro01",
                            Number = "001",
                            State = "",
                            Street = "",
                            ZipCode = "",
                            CreatedAt = DateTime.Now,
                            ModifiedAt = DateTime.Now
                        },
                        new Address
                        {
                            Id = -3,
                            ClientId = -3,
                            City = "City01",
                            Complement = "",
                            Neighborhood = "Bairro01",
                            Number = "001",
                            State = "",
                            Street = "",
                            ZipCode = "",
                            CreatedAt = DateTime.Now,
                            ModifiedAt = DateTime.Now
                        },
                        new Address
                        {
                            Id = -4,
                            ClientId = -4,
                            City = "City01",
                            Complement = "",
                            Neighborhood = "Bairro01",
                            Number = "001",
                            State = "",
                            Street = "",
                            ZipCode = "",
                            CreatedAt = DateTime.Now,
                            ModifiedAt = DateTime.Now
                        },
                        new Address
                        {
                            Id = -5,
                            ClientId = -5,
                            City = "City01",
                            Complement = "",
                            Neighborhood = "Bairro01",
                            Number = "001",
                            State = "",
                            Street = "",
                            ZipCode = "",
                            CreatedAt = DateTime.Now,
                            ModifiedAt = DateTime.Now
                        }
                    );
            #endregion

            #region Include Job
            modelBuilder.Entity<Job>().HasData(
                        new Job
                        {
                            Id = -1,
                            CategoryId = -1,
                            Description = "Job001",
                            Price = 100,
                            PriceWithDiscount = 0,
                            CreatedAt = DateTime.Now,
                            ModifiedAt = DateTime.Now
                        },
                        new Job
                        {
                            Id = -2,
                            CategoryId = -1,
                            Description = "Job002",
                            Price = 222,
                            PriceWithDiscount = 0,
                            CreatedAt = DateTime.Now,
                            ModifiedAt = DateTime.Now
                        },
                        new Job
                        {
                            Id = -3,
                            CategoryId = -2,
                            Description = "Job003",
                            Price = 300,
                            PriceWithDiscount = 0,
                            CreatedAt = DateTime.Now,
                            ModifiedAt = DateTime.Now
                        },
                        new Job
                        {
                            Id = -4,
                            CategoryId = -4,
                            Description = "Job004",
                            Price = 1000,
                            PriceWithDiscount = 0,
                            CreatedAt = DateTime.Now,
                            ModifiedAt = DateTime.Now
                        },
                        new Job
                        {
                            Id = -5,
                            CategoryId = -3,
                            Description = "Job005",
                            Price = 2000,
                            PriceWithDiscount = 0,
                            CreatedAt = DateTime.Now,
                            ModifiedAt = DateTime.Now
                        });
            #endregion

            #region Include Lead
            modelBuilder.Entity<Lead>().HasData(
                        new Lead
                        {
                            Id = -2,
                            JobId = -2,
                            ClientId = -2,
                            Approved = null,
                            CreatedAt = DateTime.Now,
                            ModifiedAt = DateTime.Now
                        },
                        new Lead
                        {
                            Id = -3,
                            JobId = -3,
                            ClientId = -3,
                            Approved = null,
                            CreatedAt = DateTime.Now,
                            ModifiedAt = DateTime.Now
                        },
                        new Lead
                        {
                            Id = -4,
                            JobId = -4,
                            ClientId = -4,
                            Approved = null,
                            CreatedAt = DateTime.Now,
                            ModifiedAt = DateTime.Now
                        },
                        new Lead
                        {
                            Id = -5,
                            JobId = -5,
                            ClientId = -5,
                            Approved = null,
                            CreatedAt = DateTime.Now,
                            ModifiedAt = DateTime.Now
                        }
                        );
            #endregion
        }
    }
}
