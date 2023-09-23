using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace proje1.Models
{
    public class Candidate
    {
        [Required(ErrorMessage = "Please enter your email address")]
        public String? email { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please enter your name")]
        public String? name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please enter your lastname")]
        public String? lastname { get; set; } = string.Empty;
        public String? fullname => $"{name} {lastname?.ToUpper()}";
        [Required(ErrorMessage = "Please select your age")]
        public String? age { get; set; } 
        [Required(ErrorMessage = "Please select a course")]
        public String? selectedcourse { get; set; } = string.Empty;
        public DateTime applyat { get; set; } 

        public Candidate()
        {
            applyat = DateTime.Now;
        }

    }
}