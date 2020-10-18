using System;
using System.Collections.Generic;
using System.Text;

namespace Marvel.Services.Character.Dto
{
    public class CharacterDataWrapper
    {
        public int? Code { get; set; }
        public string Status { get; set; }
        public string Copyright { get; set; }
        public string AttributionHtml { get; set; }
        public CharacterDataContainer Data { get; set; }
        public string Etag { get; set; }
    }
}
