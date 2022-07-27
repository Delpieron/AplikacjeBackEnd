using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using StoreApi.Models;
using StoreApi.Services;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace StoreApi.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUser _user;

        public UsersController(IUser user)
        {
            _user = user;
        }
        [AllowAnonymous]
        [ProducesDefaultResponseType(typeof(List<User>))]
        [HttpGet(ApiRoutes.User.GetUsers)]
        public async Task<IActionResult> GetUser()
        {
            var result = await _user.getUsers();
            return Ok(result);
        }
        [AllowAnonymous]
        [ProducesDefaultResponseType(typeof(User))]
        [HttpGet(ApiRoutes.User.GetUserId)]
        public async Task<IActionResult> GetUser([FromRoute] int id)
        {
            var result = await _user.getUser(id);
            return Ok(result);
        }
        [ProducesDefaultResponseType(typeof(User))]
        [HttpPost(ApiRoutes.User.AddUserId)]
        public async Task<IActionResult> AddUser([FromBody] User user)
        {
            var result = await _user.addUser(user);
            return Ok(result);
        }
        [ProducesDefaultResponseType(typeof(User))]
        [HttpPut(ApiRoutes.User.EditUserId)]
        public async Task<IActionResult> EditUser([FromBody] User user)
        {
            var result = await _user.editUser(user);
            return Ok(result);
        }
        [ProducesDefaultResponseType(typeof(User))]
        [HttpDelete(ApiRoutes.User.DeleteUserId)]
        public async Task<IActionResult> DeleteUser([FromRoute] int id)
        {
            var result = await _user.deleteUser(id);
            return Ok(result);
        }
        [HttpPost]
        [Route("ApiRoutes.User.SendMessage")]
        public async Task<IActionResult> SendMessage(EmailMessage emailMessage)
        {
            var _httpClient = new HttpClient();
            var company = JsonSerializer.Serialize(emailMessage);
            var requestContent = new StringContent(company, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("https://localhost:64128/api/v1/MailSenderPost", requestContent);
            response.EnsureSuccessStatusCode();
            return Ok(response.StatusCode);
        }
    }
}
