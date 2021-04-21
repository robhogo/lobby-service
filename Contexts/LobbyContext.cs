using lobby_service.Models;
using Microsoft.EntityFrameworkCore;


namespace lobby_service.Contexts
{
    public class LobbyContext : DbContext
    {
        public LobbyContext(DbContextOptions<LobbyContext> options) : base(options)
        {
        }

        public DbSet<Lobby> Lobbys { get; set; }

        public DbSet<LobbyCharacter> LobbyCharacters { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lobby>()
                .ToTable("Lobbys");

            modelBuilder.Entity<LobbyCharacter>()
                .ToTable("LobbyCharacters");

            base.OnModelCreating(modelBuilder);
        }


    }
}
