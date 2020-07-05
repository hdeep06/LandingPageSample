using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SampleDAL;

namespace SignupApi.Controllers
{
    [Route("api/[controller]")]
    //[ApiController]
    public class SignupController : Controller
    {
        SampleDbContext DbContext;
        public SignupController(SampleDbContext DbContext)
        {
            this.DbContext = DbContext;
        }
        // GET: api/<controller>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var Subs = await DbContext.Subscribers.ToListAsync();
                if (Subs.Count != 0)
                    return Ok(Subs);
                else
                    return NotFound();
            }
            catch (Exception)
            {

                throw;
            }
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<IActionResult> AddSubscribers(Subscribers Sub)
        {
            try
            {
                if (!IsEmailExist(Sub.Email))
                {
                    if (ModelState.IsValid)
                    {
                        DbContext.Add(Sub);
                        await DbContext.SaveChangesAsync();
                        return CreatedAtAction("Get", new { id = Sub.Id }, Sub);
                    }
                    else
                    {
                        return BadRequest(ModelState);
                    }
                }
                else
                    return BadRequest("Email already exist...!!");
            }
            catch (Exception)
            {
                throw;
            }
        }
        private bool IsEmailExist (string Email)
        {
            return DbContext.Subscribers.Any(e => e.Email == Email);
        }
    }
}
