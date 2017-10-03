using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ScopedTransientSingleton.Models;

namespace ScopedTransientSingleton.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private  ICharacterRepository characterRepository;
        private readonly ContextRepository contextRepository;

    public ValuesController(ICharacterRepository characterRepository, ContextRepository contextRepository)
    {
            this.characterRepository = characterRepository;
            this.contextRepository = contextRepository;
    }

    // GET: /characters/
    public IActionResult Index()
    {
        PopulateCharactersIfNoneExist();
        var characters = characterRepository.ListAll();

        return View(characters);
    }

    private void PopulateCharactersIfNoneExist()
    {
        if (!characterRepository.ListAll().Any())
        {
            characterRepository.Add(new Character(){ Name = "lukasz"});
            characterRepository.Add(new Character(){ Name = "Anita"});;
            characterRepository.Add(new Character(){ Name = "Stefan"});
            characterRepository.Add(new Character(){ Name = "Kunegunda"});
        }
    }
    }

}
