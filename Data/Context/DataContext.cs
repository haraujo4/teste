using Data.Entity;
using Microsoft.EntityFrameworkCore;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        Database.EnsureCreated();
    }

    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Carrinho> Carrinhos { get; set; }
    public DbSet<Produto> Produtos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>()
            .HasKey(c => c.Id);

        modelBuilder.Entity<Cliente>()
            .HasIndex(c => c.Id)
            .IsUnique();

        modelBuilder.Entity<Cliente>()
            .Property(c => c.Cpf)
            .IsRequired();

        modelBuilder.Entity<Cliente>()
            .HasIndex(c => c.Cpf)
            .IsUnique();

        modelBuilder.Entity<Cliente>()
            .Property(c => c.Nome)
            .HasMaxLength(150);

        modelBuilder.Entity<Carrinho>()
            .HasKey(c => c.Id);

        modelBuilder.Entity<Carrinho>()
            .HasIndex(c => c.Id)
            .IsUnique();

        modelBuilder.Entity<Carrinho>()
            .Property(c => c.ClienteId)
            .IsRequired();

        modelBuilder.Entity<Produto>()
            .HasKey(p => p.Id);

        modelBuilder.Entity<Produto>()
            .HasIndex(p => p.Id)
            .IsUnique();

        modelBuilder.Entity<Produto>()
            .Property(p => p.Nome)
            .IsRequired();

        modelBuilder.Entity<Produto>()
            .Property(p => p.Status)
            .IsRequired();

        modelBuilder.Entity<Produto>()
            .Property(p => p.DataCriacao)
            .IsRequired();;
    }
}