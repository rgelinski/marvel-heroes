using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Marvel.Services.Character.Enum
{
    public enum EnumFormat
    {
        [EnumMember(Value = "")]
        All = 0,
        [EnumMember(Value = "comic")]
        Comic = 1,
        [EnumMember(Value = "magazine")]
        Magazine = 2,
        [EnumMember(Value = "trade paperback")]
        TradePaperback = 3,
        [EnumMember(Value = "hardcover")]
        Hardcover = 4,
        [EnumMember(Value = "digest")]
        Digest = 5,
        [EnumMember(Value = "graphic novel")]
        GraphicNovel = 6,
        [EnumMember(Value = "digital comic")]
        DigitalComic = 7,
        [EnumMember(Value = "infinite comic")]
        InfiniteComic = 8,
    }
}
