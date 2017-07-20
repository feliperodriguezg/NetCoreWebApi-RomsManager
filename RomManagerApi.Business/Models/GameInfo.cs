using System.Collections.Generic;

namespace RomManagerApi.Business.Models
{
    public class GameInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Platform { get; set; }
        public string Description { get; set; }
        public bool ExistFile { get; set; }
        public List<FileInfo> Images { get; set; }
        public List<FileInfo> Videos { get; set; }

        public GameInfo()
        {
            InitDefaultValues();
        }

        private void InitDefaultValues()
        {
            Images = new List<FileInfo>();
            Videos = new List<FileInfo>();
            ExistFile = false;
            Id = 0;
        }
    }
}
