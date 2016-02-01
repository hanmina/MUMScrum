using System.ComponentModel.DataAnnotations;


namespace MUMScrum.Entity
{
    public abstract class User
    {
        [Display(Name = "Username")]
        [Required]
        [MinLength(3)]
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        [Required]
        [MinLength(3)]
        public string Password { get; set; }
        [Display(Name = "Deactivate")]
        public bool IsDeactivated { get; set; }
    }
}
