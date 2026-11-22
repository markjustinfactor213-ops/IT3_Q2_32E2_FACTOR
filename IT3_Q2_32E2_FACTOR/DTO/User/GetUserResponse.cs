namespace IT3_Q2_32E2_Isip_Renen.DTO.User
{
    public class GetUsersResponse
    {
        public List<GetUserDTO> Users { get; set; }
        public int TotalCount => Users?.Count ?? 0;
    }

    public class GetUserDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}