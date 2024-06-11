namespace Kolokwium2.DTO;

public class GetCharactersDTO
{
    public int Id { get; set; }
    
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int CurrentWei { get; set; }
    public int MaxWeight { get; set; }
    public ICollection<GetBackpacksDTO> Backpacks { get; set; } = null!;
}

public class GetBackpacksDTO
{
    public int CharacterId { get; set; }
    public int ItemId { get; set; }
    public int Amount { get; set; }

}