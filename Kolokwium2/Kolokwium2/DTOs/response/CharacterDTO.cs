namespace Kolokwium2.DTOs.response;

public class CharacterDTO
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public int currentWeight { get; set; }
    public int maxWeight { get; set; }
    public List<BackpackItemDTO> BackpackItemDtos { get; set; }
    public List<TitlesDTO> TitlesDtos { get; set; }

}