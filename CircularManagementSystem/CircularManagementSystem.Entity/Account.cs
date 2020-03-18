using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CircularManagementSystem.Entity
{
    public class Account
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity),Key()]
        public int AccoutId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
