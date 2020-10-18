using System.ComponentModel.DataAnnotations;

namespace Marvel.Services.Character.Enum
{
    public enum EnumFormatType
    {
        [Display(Name = "")]
        All = 0,
        [Display(Name = "comic")]
        Comic = 1,
        [Display(Name = "collection")]
        Collection = 2
    }
}
