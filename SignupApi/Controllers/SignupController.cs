using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SampleDAL;

// Web API Controller which stores records in database (model) using POST and retrieve record using GET HTTP verbs.
namespace SignupApi.Controllers
{
    [Route("api/[controller]")]
    public class SignupController : Controller
    {
        SampleDbContext DbContext;
        public SignupController(SampleDbContext DbContext)
        {
            this.DbContext = DbContext;
        }
        // GET: api/<controller>
        [HttpGet]
        public async Task<IActionResult> Get()                                      //To reterieve resullt
        {
            try
            {
                var Subs = await DbContext.Subscribers.ToListAsync();
                if (Subs.Count != 0)                                                //Check if records in table exists or not
                    return Ok(Subs);
                else
                    return BadRequest("No Record Exist...!!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<IActionResult> AddSubscribers(Subscribers Sub)            //To store the new record
        {
            try
            {
                if (!IsEmailExist(Sub.Email))                                       //Check if Email already exist or not.
                {
                    if (ModelState.IsValid)                                         //Check if specified model state such as [Required] is valid request or not
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
        private bool IsEmailExist (string Email)                                   //Returns the already exist email in the record
        {
            return DbContext.Subscribers.Any(e => e.Email == Email);
        }
    }
}
