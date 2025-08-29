using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")] // localhost:5001/api/members
    [ApiController]
    public class MembersController(AppDbContext context) : ControllerBase
    {
        [HttpGet]
        public ActionResult<IReadOnlyList<AppUser>> GetMembers()
        {
            var members = context.Users.ToList();

            return members;
        }

        [HttpGet("{id}")] // https://localhostr:5001/api/members/bob-id
        public ActionResult<AppUser> GetMember(string id)
        {
            var member = context.Users.Find(id);
            // var member2 = context.Users.FirstOrDefault(x => x.Id == id);
            if (member == null) return NotFound();

            return member;
        }
    }
}
