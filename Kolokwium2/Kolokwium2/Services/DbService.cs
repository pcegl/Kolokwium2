using Kolokwium2.Data;
using Kolokwium2.Models;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium2.Services;

public class DbService : IDbService
{
    private readonly DatabaseContext _context;
    public DbService(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<ICollection<Characters>> GetCharactersData(int IdCharacter)
    {
        return await _context.Characters
            .Where(c => c.Id == IdCharacter)
            .Include(c => c.Backpacks)
            .Include(c => c.CharacterTitles)
            .ToListAsync();
    }

    public async Task<bool> DoesCharactertExist(int characterID)
    {
        return await _context.Characters.AnyAsync(e => e.Id == characterID);    }
}