using System.ComponentModel.DataAnnotations;

namespace PropMan.Models
{
    public enum AdType
    {
        [Display(Name = "اجاره")]
        Let,
        [Display(Name = "فروش")]
        Sale
    }
}