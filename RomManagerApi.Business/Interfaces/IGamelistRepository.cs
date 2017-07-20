
namespace RomManagerApi.Business.Interfaces
{
    public interface IGamelistRepository
    {
        GetGamelistResponse GetGamelist(GetGamelistRequest request);
        SearchResponse Search(SearchRequest request);
    }
}
