using IT3_Q2_32E2_Isip_Renen.DTO.User;

namespace IT3_Q2_32E2_Gonzales_Krister.DTO.User
{
    public class GetUserByIDResponse
    {
        public GetUserDTO? User { get; set; }
        public List<GetUserGroupDTO> UserGroups { get; set; } = new();
    }

    public class GetUserGroupDTO
    {
        public int UserId { get; set; }
        public int GroupId { get; set; }
    }
}