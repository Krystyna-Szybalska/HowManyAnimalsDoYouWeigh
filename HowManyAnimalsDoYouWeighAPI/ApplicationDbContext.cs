using HowManyAnimalsDoYouWeighAPI.FunFacts;
using HowManyAnimalsDoYouWeighAPI.ItemFunFacts;
using HowManyAnimalsDoYouWeighAPI.Items;
using HowManyAnimalsDoYouWeighAPI.Visualizations;
using Microsoft.EntityFrameworkCore;

namespace HowManyAnimalsDoYouWeighAPI
{
    public class ApplicationDbContext : DbContext {
        
        public DbSet<Animal> Animals { get; set; }
        public DbSet<AnimalFunFact> AnimalFunFacts { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemFunFact> ItemFunFacts { get; set; }
        public DbSet<Substance> Substances { get; set; }
        public DbSet<Visualization> Visualizations { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}