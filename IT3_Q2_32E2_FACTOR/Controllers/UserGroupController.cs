using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using IT3_Q2_32E2_Isip_Renen.DTO.UserGroup;

namespace IT3_Q2_32E2_Isip_Renen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserGroupController : ControllerBase
    {
        // GET: api/<UserGroupController>
        [HttpGet]
        public IActionResult Get()
        {
            var response = new GetUserGroupsResponse
            {
                UserGroups = new()
                {
                    new(){Id = 1, Name = "Administrators", Description = "Full access"},
                    new(){Id = 2, Name = "Editors", Description = "Can edit content"},
                    new(){Id = 3, Name = "Viewers", Description = "Read-only access"},
                }
            };
            return Ok(response);
        }

        // GET api/<UserGroupController>/5
        [HttpGet("{id}")]
        public IActionResult Get([Range(1, int.MaxValue, ErrorMessage = "Id must be a positive number.")] int id)
        {
            return Ok(new GetUserGroupByIDResponse
            {
                UserGroup = new UserGroupDTO
                {
                    Id = id,
                    Name = "Administrators",
                    Description = "Full access"
                }
            });
        }

        // POST api/<UserGroupController>
        [HttpPost]
        public IActionResult Post([FromBody] CreateUserGroupsRequest request)
        {
            return Ok(new CreateUserGroupsResponse
            {
                Id = 4,
                Name = request.Name,
                Description = request.Description
            });
        }

        // PUT api/<UserGroupController>/5
        [HttpPut("{id}")]
        public IActionResult Put([Range(1, int.MaxValue, ErrorMessage = "Id must be a positive number.")] int id, [FromBody] EditUserGroupsRequest request)
        {
            return Ok(new EditUserGroupsResponse
            {
                Id = id,
                Name = request.Name,
                Description = request.Description
            });
        }

        // DELETE api/<UserGroupController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete([Range(1, int.MaxValue, ErrorMessage = "Id must be a positive number.")] int id)
        {
            return NoContent();
        }
    }
}