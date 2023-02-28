
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlinePustak.Models;

namespace OnlinePustak.Controllers;

[ApiController]
public class LibraryController : ControllerBase
{
       private readonly ACE42023Context db = new();
        public LibraryController(ACE42023Context _db, IHttpContextAccessor httpContextAccessor)
        {
            db = _db;
        }
        
        [HttpGet]
        [Route("api/Library", Name = "GetAllBooks")]
        public async Task<ActionResult<IEnumerable<SameerLmsBookCollection>>> BookCollection(){
            return Ok(await db.SameerLmsBookCollections.ToListAsync());
        }

        [HttpGet]
        [Route("api/Library/{id:int}", Name="GetBookByISBN")]
        public async Task<ActionResult> GetBookByID(int? id){
            if(id == null){
                return BadRequest(new {Message = "Book ID is Required!"});
            }
            SameerLmsBookCollection b = await db.SameerLmsBookCollections.FindAsync(id);
            if(b!=null){
                return Ok(b);
            }
            return NotFound(new {Message = "Book not found!"});
        }

        [HttpPost]
        [Route("api/Library/Admin/AddBook", Name="AddBook")]
        public async Task<ActionResult> AddBook([FromBody] SameerLmsBookCollection? b){
            if(b == null){
                return BadRequest(new {Message = "Please Provide all the necessary details!"});
            }
            if(ModelState.IsValid){
                db.SameerLmsBookCollections.Add(b);
                await db.SaveChangesAsync();
                return Ok(b);
            }
            else{
                return BadRequest(new {Message = "Please Provide details in valid form!"});
            }
        }

        [HttpPut]
        [Route("api/Library/Admin/EditBook/{id:int}", Name="EditBook")]
        public async Task<ActionResult> EditBook(int? id,[FromBody] SameerLmsBookCollection? g){
            
            if(id == null) return BadRequest(new {Message = "Book ID is Required!"});
            SameerLmsBookCollection b = await db.SameerLmsBookCollections.FindAsync(id);
            if(b == null){
                return BadRequest(new {Message = "Book not found!"});
            }
                b.BookName = g.BookName;
                b.Isbn = g.Isbn;
                b.PublishDate = g.PublishDate;
                b.Category = g.Category;
                b.Quantity = g.Quantity;
                b.AuthorName = g.AuthorName;
                db.SameerLmsBookCollections.Update(b);
                await db.SaveChangesAsync();
            return Ok(b);
        }
       
        
}