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
        }
    }
}

