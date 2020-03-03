using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web.Odev.Data;
using Web.Odev.Domain.Models;

namespace Web.Odev.Controllers
{
    [Route("api/mainpage")]
    [ApiController]
    public class MainPageController : ControllerBase
    {

        private readonly WebOdevContext _context;

        public MainPageController(WebOdevContext context)
        {
            _context = context;
        }

        // GET: api/Products
       
        [HttpGet]
        
        public async Task<ActionResult<IEnumerable<MainPage>>> GetMAinPage()
        {
            //var db = _context.Database.GenerateCreateScript();
            return await _context.MainPage.ToListAsync();
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MainPage>> GetMAinPage(int id)
        {
            var mainpage  = await _context.MainPage.FindAsync(id);

            if (mainpage == null)
            {
                return NotFound();
            }

            return mainpage;
        }

        // PUT: api/Products/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMainPage(int id, MainPage mainpage)
        {
            if (id != mainpage.Id)
            {
                return BadRequest();
            }

            _context.Entry(mainpage).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MainPageExist(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Products
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        //[Route("api/postmainpage")]
        [HttpPost]
        public async Task<ActionResult<MainPage>> PostProduct(MainPage mainpage)
        {
            _context.MainPage.Add(mainpage);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMainPage", new { id = mainpage.Id }, mainpage);
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<MainPage>> DeleteMainPage(int id)
        {
            var mainpage = await _context.MainPage.FindAsync(id);
            if (mainpage == null)
            {
                return NotFound();
            }

            _context.MainPage.Remove(mainpage);
            await _context.SaveChangesAsync();

            return mainpage;
        }

        private bool MainPageExist(int id)
        {
            return _context.MainPage.Any(e => e.Id == id);
        }
    












    //// GET: api/MainPage
    //[HttpGet]
    //public IEnumerable<string> Get()
    //{
    //    return new string[] { "value1", "value2" };
    //}

    //// GET: api/MainPage/5
    //[HttpGet("{id}", Name = "Get")]
    //public string Get(int id)
    //{
    //    return "value";
    //}

    //// POST: api/MainPage
    //[HttpPost]
    //public void Post([FromBody] string value)
    //{
    //}

    //// PUT: api/MainPage/5
    //[HttpPut("{id}")]
    //public void Put(int id, [FromBody] string value)
    //{
    //}

    //// DELETE: api/ApiWithActions/5
    //[HttpDelete("{id}")]
    //public void Delete(int id)
    //{
    //}
}
}
