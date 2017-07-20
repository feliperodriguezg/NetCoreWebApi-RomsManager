using System;
using System.Collections.Generic;
using System.Text;

namespace RomManagerApi.Business.Models
{
    public class GamelistInfo
    {
        public string Platform { get; set; }
        public string PathGamelistXml { get; set; }
        public List<GameInfo> Games { get; set; }

        public GamelistInfo()
        {
            Games = new List<GameInfo>();
        }
    }
}
