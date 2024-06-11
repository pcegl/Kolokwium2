using Kolokwium2.Models;

namespace Kolokwium2.Services;

public interface IDbService
{
    Task<ICollection<Characters>> GetCharactersData(int IdCharacter);
    Task<bool> DoesCharactertExist(int clientID);

}