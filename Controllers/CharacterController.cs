using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<Character> characters = new List<Character> {
            new Character(),
            new Character { Id = 1, Name = "Sam" }
        };
        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }


        [HttpGet]
        [Route("GetAll")]
        public ActionResult<List<Character>> Get() {
            return Ok(_characterService.GetAllCharacters());
        }

        [HttpPost("{id}")]
        public ActionResult<Character> GetSingle(int id) 
        {
            return Ok( _characterService.GetCharacterById(id));
        }


        [HttpPost]
        public ActionResult<List<Character>> AddCharacter(Character newcharacter)
        {
            return Ok(_characterService.AddCharacter(newcharacter));
        }
    } 
}