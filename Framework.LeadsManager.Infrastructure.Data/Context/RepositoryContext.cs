using Framework.LeadsManager.Domain.Entities;
using Framework.LeadsManager.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Framework.LeadsManager.Infrastructure.Data.Context
{
    public class RepositoryContext : DbContext, IUnitOfWork
    {
        public DbSet<Lead> Lead { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Job> Job { get; set; }
        public DbSet<Address> Address { get; set; }
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options){}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(@"Server=localhost;Database=framework.leads.manager;Trusted_Connection=True;");
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var type in modelBuilder.Model.GetEntityTypes().Where(e => typeof(Entity).IsAssignableFrom(e.ClrType)))
                modelBuilder
                    .Entity(type.ClrType)
                    .HasKey("Id");

            foreach (var type in modelBuilder.Model.GetEntityTypes().Where(e => typeof(Entity).IsAssignableFrom(e.ClrType)))
            {
                modelBuilder
                    .Entity(type.ClrType)
                    .Property<DateTime>("CreatedAt")
                    .IsRequired();

                modelBuilder
                    .Entity(type.ClrType)
                    .Property<DateTime?>("ModifiedAt");
            }            
        }
        private void SetDefaultValues()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("CreatedAt") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("CreatedAt").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("ModifiedAt").CurrentValue = DateTime.Now;
                    entry.Property("CreatedAt").IsModified = false;
                }
            }
        }

        public override int SaveChanges()
        {
            SetDefaultValues();
            return base.SaveChanges();
        }

        public async override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            SetDefaultValues();
            return await base.SaveChangesAsync(cancellationToken);
        }

        public async override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            SetDefaultValues();
            return await base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        public async Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default)
        {
            await base.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}
