
using Microsoft.AspNetCore.Mvc;
using OnlinePustak.Models;

namespace OnlinePustak.Controllers;

[ApiController]
public class LoginController : ControllerBase
{
       private readonly ACE42023Context db = new();
        public LoginController(ACE42023Context _db, IHttpContextAccessor httpContextAccessor)
        {
            db = _db;
        }
        
        [HttpPost]
        [Route("api/Login", Name = "Authentication")]
        public  ActionResult Login(SameerLmsUser? u){
            if(u.UserId == null || u.Password == null){
                return BadRequest(new {Message = "Username and Password are Required!"});
            } 
            var result = (from i in db.SameerLmsUsers
                            where  i.UserId == u.UserId && i.Password == u.Password
                            select i).SingleOrDefault();
            
            if(result != null){
                return Ok(result);
            }
            else{
                
                return Unauthorized(new {Message = "Invalid Credentials!"});
            }
        }

        [HttpPost]
        [Route("api/Register", Name = "Register")]
        public async Task<ActionResult> Register(SameerLmsUser? u){

            if(u == null){
                return BadRequest(new {Message = "Please Provide all the necessary details!"});
            }

            var check_u = db.SameerLmsUsers.Where(x => x.UserId == u.UserId).SingleOrDefault();

            if(check_u != null){
                return BadRequest(new {Message = "User already Exists!"});
            }
            if(ModelState.IsValid){
                db.SameerLmsUsers.Add(u);
                await db.SaveChangesAsync();
                return Ok(u);
            }else{
                return BadRequest("Please Provide details in valid form!");
            }
        }
}