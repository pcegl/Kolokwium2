using Kolokwium2.DTO;
using Kolokwium2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Kolokwium2.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CharactersController : ControllerBase
{
    private readonly IDbService _dbService;
    public CharactersController(IDbService dbService)
    {
        _dbService = dbService;
    }
    
    
    [HttpGet("{CharacterId}")]
    public async Task<IActionResult> GetCharactersData(int CharacterId)
    {
        var characters = await _dbService.GetCharactersData(CharacterId);
        
        return Ok(characters.Select(e => new GetCharactersDTO()
        {
            Id = CharacterId,
            FirstName = e.FirstName,
            LastName = e.LastName,
            CurrentWei = e.CurrentWei,
            MaxWeight = e.MaxWeight,
            Backpacks = e.Backpacks.Select(p => new GetBackpacksDTO()
            {
                CharacterId = p.CharacterId,
                ItemId = p.ItemId,
                Amount = p.Amount
            }).ToList()
        }));
        
    }
}