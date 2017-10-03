

using System.Collections.Generic;

namespace ScopedTransientSingleton.Models
{
    public interface ICharacterRepository
    {
        string _OutputString {set; get; }
        void ChangeLowerCaseToUpCaseInString (string _parameter) ;

        IEnumerable<Character> ListAll();
        void Add (Character _parameter);

    }
}