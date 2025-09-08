using Microsoft.EntityFrameworkCore;
using Pokedex.Models;

namespace Pokedex.Data
{

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)

        {

        }

        public DbSet<Genero> Genero { get; set; }
        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<PokemonTipo> PokemonsTipos { get; set; }
        public DbSet<Regiao> Regiao { get; set; }
        public DbSet<Tipo> Tipos { get; set; }
    }
}