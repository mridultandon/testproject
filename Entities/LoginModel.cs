using System.ComponentModel.DataAnnotations;

namespace TestProject.Entities
{
    public class LoginModel
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }    
        public string Password { get; set; }

        public int UserType { get; set; }
    }
}