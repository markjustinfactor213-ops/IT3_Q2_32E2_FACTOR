namespace IT3_Q2_32E2_Isip_Renen.DTO.UserGroup
{
    public class GetUserGroupsResponse
    {
        public List<UserGroupDTO> UserGroups { get; set; } = new();
        public int TotalCount => UserGroups?.Count ?? 0;
    }

    public class UserGroupDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
    }
}