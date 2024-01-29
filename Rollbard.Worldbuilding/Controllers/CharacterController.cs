using Microsoft.AspNetCore.Mvc;
using Rollbard.Library.Models;
using Rollbard.Library.Rollers.Interfaces;

namespace Rollbard.Worldbuilding.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController(ICharacterRoller characterRoller) : ControllerBase
    {
        private readonly ICharacterRoller characterRoller = characterRoller;

        [HttpGet]
        public Character GetCharacter()
        {
            return this.characterRoller.Get();
        }
    }
}