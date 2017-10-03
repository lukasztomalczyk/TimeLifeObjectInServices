using Microsoft.EntityFrameworkCore;

namespace ScopedTransientSingleton.Models
{
  public class Character
  {
      public int Id { get; set; }
      public string Name { get; set; }
  }
}