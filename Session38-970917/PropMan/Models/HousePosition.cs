using System.ComponentModel.DataAnnotations;

namespace PropMan.Models
{
    public enum HousePosition
    {
        [Display(Name = "شمالی")]
        North,
        [Display(Name = "جنوبی")]
        South,
        [Display(Name = "غربی")]
        West,
        [Display(Name = "شرقی")]
        East
    }
}