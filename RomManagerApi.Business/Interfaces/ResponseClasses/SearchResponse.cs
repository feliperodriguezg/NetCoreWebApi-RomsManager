using RomManagerApi.Business.Models;
using System.Collections.Generic;

namespace RomManagerApi.Business.Interfaces
{
    public class SearchResponse
    {
        public List<GameInfo> Results { get; set; }

        public SearchResponse()
        {
            Results = new List<GameInfo>();
        }
    }
}