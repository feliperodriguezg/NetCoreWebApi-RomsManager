using RomManagerApi.Business.Models;
using System.Collections.Generic;

namespace RomManagerApi.Business.Interfaces
{
    public class GetGamelistResponse
    {
        public List<GamelistInfo> Result { get; set; }

        public GetGamelistResponse()
        {
            Result = new List<GamelistInfo>();
        }
    }
}