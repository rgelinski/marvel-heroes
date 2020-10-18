using Marvel.Interfaces.DTO;
using System;
using System.Collections.Generic;

namespace Marvel.Services.Character.Dto
{
    public class CharacterInfo : IDataObject
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Modified { get; set; }
        public string ResourceUri { get; set; }
        public ICollection<string> Urls { get; set; }
    }
}