using System;
using System.Collections.Generic;
using System.Text;

namespace RomManagerApi.Business.Models
{
    public class FileInfo
    {
        public byte[] Data { get; set; }
        public string Path { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Extension { get; set; }
    }
}
