using System.ComponentModel.DataAnnotations;


namespace MUMScrum.Entity
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Role")]
        public string RoleName { get; set; }
    }
}
