using System.ComponentModel.DataAnnotations;

namespace Marvel.Services.Character.Enum
{
    public enum EnumResultOrder
    {
        [Display(Name = "name")]
        Name = 0,
        [Display(Name = "modified")]
        Modified = 1,
        [Display(Name = "-name")]
        ReverseName = 2,
        [Display(Name = "-modified")]
        ReverseModified = 3,
    }
}
