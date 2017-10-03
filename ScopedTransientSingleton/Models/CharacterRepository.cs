

using System.Collections.Generic;
using DifferenceBetweenScopedTransientSingleton.Models;

namespace DifferenceBetweenScopedTransientSingleton
{

    public class CharacterRepository : ICharacterRepository
    {
        public CharacterRepository(ContextRepository _context)
        {
            this.context = _context;
        }
        public string _OutputString { get; set;}
        public ContextRepository context { get; set; }

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
            return context
        }

    }
}