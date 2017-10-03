using Microsoft.EntityFrameworkCore;

namespace ScopedTransientSingleton.Models {

    public class ContextRepository : DbContext {

    public ContextRepository(DbContextOptions<ContextRepository> options) : base (options)
    {
    }
       DbSet<Character> Characters {get; set; }
    }
}