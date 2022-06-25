using HowManyAnimalsDoYouWeighAPI.FunFacts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HowManyAnimalsDoYouWeighAPI.Configurations
{
    public class AnimalConfiguration : IEntityTypeConfiguration<Animal>
    {
        public void Configure(EntityTypeBuilder<Animal> builder)
        {
            builder
                .HasKey(a => a.Id);

            builder
                .HasMany<AnimalFunFact>(a => a.FunFacts); //TODO check if correct
        }
    }
}