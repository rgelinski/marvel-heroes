using Marvel.Services.Common.Base;
using System.Collections.Generic;
using System.Linq;

namespace Marvel.Services.Character.Dto
{
    public class CharacterDataContainer : DataContainerBase<CharacterInfo>
    {
        public CharacterDataContainer(IQueryable<CharacterInfo> unpaginatedResult, int pageAmount, int skip = 0) : base(unpaginatedResult, pageAmount, skip)
        {
        }
    }
}