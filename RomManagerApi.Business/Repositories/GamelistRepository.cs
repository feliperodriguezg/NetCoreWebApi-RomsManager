using RomManagerApi.Business.Interfaces;
using System;
using RomManagerApi.Business.Enums;

namespace RomManagerApi.Business.Repositories
{
    public class GamelistRepository : IGamelistRepository, IPlatformsRepository
    {
        public string[] GetPlatforms()
        {
            return Enum.GetNames(typeof(Platforms));
        }
        public GetGamelistResponse GetGamelist(GetGamelistRequest request)
        {
            throw new NotImplementedException();
        }
        public SearchResponse Search(SearchRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
