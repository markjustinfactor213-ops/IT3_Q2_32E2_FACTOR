using System.ComponentModel.DataAnnotations;

namespace IT3_Q2_32E2_Isip_Renen.DTO.UserGroup
{
    public class CreateUserGroupsRequest
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 50 characters.")]
        public string Name { get; set; } = string.Empty;

        [StringLength(200, ErrorMessage = "Description must not exceed 200 characters.")]
        public string? Description { get; set; }
    }
}