//using Solution.Domain.Models;

//namespace solution.Repository.MyContext
//{
//    public partial class MyDbContext : DbContext
//    {
//        public Context(DbContextOptions<Context> options) : base(options)
//        { }

//        public DbSet<Cliente> Cliente { get; set; }
//        public DbSet<Produto> Produto { get; set; }
//        public DbSet<ClienteProduto> ClienteProduto { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//                optionsBuilder.UseSqlServer("Password=123;Persist Security Info=True;User ID=sa;Initial Catalog=ConspiracaoDB;Data Source=DESKTOP-EUD6FT9\\SQLEXPRESS");
//            }
//        }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.Entity<Cliente>(entity =>
//            {
//                entity.HasKey(e => e.IdCliente)
//                    .HasName("PKCliente");

//                entity.Property(e => e.Nome)
//                    .IsRequired()
//                    .HasMaxLength(20);
//            });

//            modelBuilder.Entity<ClienteProduto>(entity =>
//            {
//                entity.HasKey(e => new { e.IdCliente, e.IdProduto })
//                    .HasName("PKClienteProduto");

//                entity.HasOne(d => d.IdClienteNavigation)
//                    .WithMany(p => p.ClienteProduto)
//                    .HasForeignKey(d => d.IdCliente)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FK__ClientePr__IdCli__46E78A0C");

//                entity.HasOne(d => d.IdProdutoNavigation)
//                    .WithMany(p => p.ClienteProduto)
//                    .HasForeignKey(d => d.IdProduto)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FK__ClientePr__IdPro__47DBAE45");
//            });

//            modelBuilder.Entity<Produto>(entity =>
//            {
//                entity.HasKey(e => e.IdProduto)
//                    .HasName("PKProduto");

//                entity.Property(e => e.Nome)
//                    .IsRequired()
//                    .HasMaxLength(150);
//            });

//            OnModelCreatingPartial(modelBuilder);
//        }

//        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
//    }
//}
