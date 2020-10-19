using System;
using System.Collections.Generic;
using System.Linq;
using Marvel.Services.Character.Dto;
using Marvel.Services.Character.Enum;
using MarvelBackend.Utils;
using Microsoft.AspNetCore.Mvc;

namespace MarvelBackend.Controllers
{
    [Route("v1/public/[controller]")]
    [ApiController]
    public class CharactersController : ControllerBase
    {
        [HttpGet]
        public ActionResult<CharacterDataContainer> Get([FromQuery] string name,
                                                        [FromQuery] string nameStartsWith,
                                                        [FromQuery] DateTime modifiedSince,
                                                        [FromQuery] string comics,
                                                        [FromQuery] string series,
                                                        [FromQuery] string events,
                                                        [FromQuery] string stories,
                                                        [FromQuery] ResultOrder orderBy,
                                                        [FromQuery] int limit,
                                                        [FromQuery] int offset)
        {
            comics.ValidateArrays(nameof(comics));
            series.ValidateArrays(nameof(series));
            events.ValidateArrays(nameof(events));
            stories.ValidateArrays(nameof(stories));

            return new CharacterDataContainer(new List<CharacterInfo>().AsQueryable(), limit, offset);
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "character";
        }


        [HttpGet("{id}/comics")]
        public string GetByComics([FromRoute] int id,
                                  [FromQuery] string format,
                                  [FromQuery] string formatType,
                                  [FromQuery] bool? noVariants,
                                  [FromQuery] string dateDescriptor)
        {
            if (!string.IsNullOrWhiteSpace(format)
                && !Enum.TryParse(typeof(EnumFormat), format, out _))
            {
                throw new ArgumentException($"'{nameof(format)}' invalid", nameof(format));
            }

            if (!string.IsNullOrWhiteSpace(formatType)
                && !Enum.TryParse(typeof(EnumFormatType), formatType, out _))
            {
                throw new ArgumentException($"'{nameof(formatType)}' invalid", nameof(formatType));
            }

            return "comics";
        }
    }
}
