using Microsoft.EntityFrameworkCore;

namespace DifferenceBetweenScopedTransientSingleton.Models
{
  public class Character
  {
    public int Id { get; set; }
     public string _name { get; set; }

     public Character(string Parameters)
     {
         this._name = Parameters;
     }


  }
}