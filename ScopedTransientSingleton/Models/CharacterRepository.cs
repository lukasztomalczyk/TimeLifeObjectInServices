

using System.Collections.Generic;
using ScopedTransientSingleton.Models;

namespace ScopedTransientSingleton
{

    public class CharacterRepository : ICharacterRepository
    {
        public ContextRepository context { get; set; }

        public CharacterRepository(ContextRepository _context)
        {
            context = _context;
        }
        public string _OutputString { get; set;}


        public void Add(Character _parameter)
        {
            context.Add(_parameter);
            context.SaveChanges();
        }

        public void ChangeLowerCaseToUpCaseInString (string _parameter)
        {
            _OutputString = _parameter;
           _OutputString.ToUpper();
        }

        public IEnumerable<Character> ListAll()
        {
            return context.
        }

    }
}