using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Db40Spike.Web.Models
{
    public class CreatePersonViewModel
    {
        [Required]
        [DisplayName("First Name")]
        public string first_name { get; set; }

        [Required]
        [DisplayName("Last Name")]
        public string last_name { get; set; }
    }
}