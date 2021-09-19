using System.ComponentModel.DataAnnotations;

namespace IndentityLogReg_Project.ViewMdl
{
    public class Register
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string EMail { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage ="Password and Confornation password DO NOT MATCH!")]
        public string ConfirmPassword { get; set; }
    }
}
