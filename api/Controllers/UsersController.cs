using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ClassroomHelperBackend.Database;
// using ClassroomHelperBackend.Models.Database;
// using ClassroomHelperBackend.Models.Request;

namespace ClassroomHelperBackend.Controllers
{
    [ApiController]
    [Route("/users")]
    public class UsersController : ControllerBase
    {
    // private UserManager<ClassroomHelperUser> _userManager;
    //     private RoleManager<IdentityRole> _roleManager;
    private readonly ClassroomHelperDbContext _context;

        // public UsersController(
        //     UserManager<ClassroomHelperUser> userManager,
        //     RoleManager<IdentityRole> roleManager,
        //     ClassroomHelperDbContext context
        // )
        // {
        //     _userManager = userManager;
        //     _roleManager = roleManager;
        //     _context = context;
        // }

        // [HttpGet()]
        // public async Task<ActionResult> Create([FromBody] CreateUserRequest newUser)
        // {
        // }
            

    }
}
