using Microsoft.AspNetCore.Mvc;
using IT3_Q2_32E2_Isip_Renen.DTO;
using System.ComponentModel.DataAnnotations;
using IT3_Q2_32E2_Isip_Renen.DTO.User;
using IT3_Q2_32E2_Isip_Renen.DTO.UserGroup;
using IT3_Q2_32E2_Gonzales_Krister.DTO.User;
namespace IT3_Q2_32E2_Isip_Renen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET: api/<UserController>
        [HttpGet]
        public IActionResult Get()
        {
            var response = new GetUsersResponse
            {
                Users = new()
                {
                    new(){Id = 1, Name = "John Doe", Email = "john.doe@example.com"},
                    new(){Id = 2, Name = "John Otto", Email = "john.otto@example.com"},
                    new(){Id = 3, Name = "Jane Doe", Email = "jane.doe@example.com"},
                    new(){Id = 4, Name = "Luna Valeria", Email = "luna.valeria@example.com"},
                    new(){Id = 5, Name = "Kierra Ynares", Email = "kierra.ynares@example.com"},
                    new(){Id = 6, Name = "Kalix Martinez", Email = "kalix.martinez@example.com"},
                    new(){Id = 7, Name = "Shan Lopez", Email = "shan.lopez@example.com"},
                    new(){Id = 8, Name = "Yanna Fernandez", Email = "yanna.fernandez@example.com"},
                    new(){Id = 9, Name = "Hiro Juarez", Email = "hiro.juarez@example.com"},
                    new(){Id = 10, Name = "Samantha Vera", Email = "samantha.vera@example.com"},
                }
            };
            return Ok(response);
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public IActionResult Get([Range(1, int.MaxValue, ErrorMessage = "Id must be a positive number.")] int id)
        {
            return Ok(new GetUserByIDResponse
            {
                User = new GetUserDTO
                {
                    Id = id,
                    Name = "John Doe",
                    Email = "john.doe@example.com"
                },
                UserGroups = new()
                {
                    new(){UserId = id, GroupId = 1},
                    new(){UserId = id, GroupId = 2},
                }
            });
        }

        // POST api/<UserController>
        [HttpPost]
        public IActionResult Post([FromBody] CreateUsersResponse request)
        {
            return Ok(new CreateUsersResponse
            {
                Id = 11,
                Name = request.Name,
                Email = request.Email
            });
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public IActionResult Put([Range(1, int.MaxValue, ErrorMessage = "Id must be a positive number.")] int id, [FromBody] EditUsersResponse request)
        {
            return Ok(new EditUsersResponse
            {
                Id = id,
                Name = request.Name,
                Email = request.Email
            });
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete()
        {
            return NoContent();
        }
    }
}