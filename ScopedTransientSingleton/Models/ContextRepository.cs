using Microsoft.EntityFrameworkCore;

namespace DifferenceBetweenScopedTransientSingleton.Models {

    public class ContextRepository : DbContext {


       DbSet<Character> Characters {get; set; }
    }
}