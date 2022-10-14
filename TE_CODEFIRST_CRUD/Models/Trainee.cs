using System.ComponentModel.DataAnnotations;

namespace TE_CODEFIRST_CRUD.Models
{
    public class Trainee
    {
        [Key]
        public int TraineeID { get; set; }

        [Required(ErrorMessage = "Enter Name")]
        [RegularExpression(@"^([A-Za-z]+)$")]
        public string TraineeName { get; set; }

        [Range(21, 58, ErrorMessage = "Enter age between 21 to 58")]
        public int TraineeAge { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string TraineeMobile { get; set; }

        [DataType(DataType.EmailAddress)]
        public string TraineeEmail { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Enter the Password")]
        public string TPassword { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Enter the Confirm Password")]
        [Compare("TPassword", ErrorMessage = "Password does not match")]
        public string TConfirmPassword { get; set; }

    }
}
