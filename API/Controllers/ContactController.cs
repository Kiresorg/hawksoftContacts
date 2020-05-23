using System.Collections.Generic;
using System.Threading.Tasks;
using ContactsDb;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly DataContext _Context;
        public ContactController(DataContext context)
        {
            _Context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Contact>>>  Get()
        {
            var values = await _Context.Contacts.ToListAsync();
            return Ok(values);
        }
    }
}