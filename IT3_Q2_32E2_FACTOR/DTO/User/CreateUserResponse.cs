using System.ComponentModel.DataAnnotations;

namespace IT3_Q2_32E2_Isip_Renen.DTO.User
{
    public class CreateUsersResponse
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 100 characters.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Email is not a valid email address.")]
        public string Email { get; set; } = string.Empty;
    }
}