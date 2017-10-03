using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DifferenceBetweenScopedTransientSingleton.Models;

namespace DifferenceBetweenScopedTransientSingleton.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
 private  ICharacterRepository _characterRepository;

        public ContextRepository _contentRepository { get; set; }

        public ValuesController(ICharacterRepository characterRepository)
    {
        _characterRepository = characterRepository;

    }

    // GET: /characters/
    public IActionResult Index()
    {
        PopulateCharactersIfNoneExist();
        var characters = _characterRepository.ListAll();

        return View(characters);
    }

    private void PopulateCharactersIfNoneExist()
    {
        if (!_characterRepository.ListAll().Any())
        {
            _characterRepository.Add(new Character("Darth Maul"));
            _characterRepository.Add(new Character("Darth Vader"));
            _characterRepository.Add(new Character("Yoda"));
            _characterRepository.Add(new Character("Mace"));
        }
    }
    }

}
