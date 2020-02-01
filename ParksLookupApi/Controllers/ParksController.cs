using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ParksLookupApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ParksLookupApi.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class ParksController : ControllerBase
    {
        private ParksLookupApiContext _db;
        public ParksController(ParksLookupApiContext db)
        {
            _db = db;
        }
        // GET /parks
        [HttpGet]
        public ActionResult<IEnumerable<Park>> Get()
        {
            return _db.Parks.ToList();
        }

        // GET /parks/5
        [HttpGet("{id}")]
        public ActionResult<Park> Get(int id)
        {
            return _db.Parks.FirstOrDefault(entry => entry.ParkId == id);
        }

        // POST /parks
        [HttpPost]
        public void Post([FromBody] Park thePark)
        {
            _db.Parks.Add(thePark);
            _db.SaveChanges();
        }

        // PUT /parks/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Park thePark)
        {
            thePark.ParkId = id;
            _db.Entry(thePark).State = EntityState.Modified;
            _db.SaveChanges();
        }

        // DELETE /parks/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Park deletePark = _db.Parks.FirstOrDefault(entry => entry.ParkId == id);
            _db.Parks.Remove(deletePark);
            _db.SaveChanges();
        }

        // RANDOM /parks/random
        [HttpGet("/[controller]/random")]
        public ActionResult<Park> RandomPark()
        {
            int number = _db.Parks.ToList().Count;
            Random rand = new Random();
            int random = rand.Next(number) + 1;
            Park randomPark = _db.Parks.FirstOrDefault(entry => entry.ParkId == random);
            return randomPark;
        }
    }
}
