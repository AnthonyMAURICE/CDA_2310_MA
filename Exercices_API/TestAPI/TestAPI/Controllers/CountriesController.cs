﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestAPI.Db;
using TestAPI.Models;

namespace TestAPI.Controllers
{
    [Route("api/Countries")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private readonly CountryDbContext _context;

        public CountriesController(CountryDbContext context)
        {
            _context = context;
        }

        // GET: api/Countries
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Country>>> GetCountries()
        {
            return await _context.Countries.Include(c => c.Cities).ToListAsync();
        }

        // GET: api/Countries/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Country>> GetCountry(int id)
        {
            var country = await _context.Countries.FindAsync(id);

            if (country == null)
            {
                return NotFound();
            }

            return country;
        }

        // PUT: api/Countries/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCountry(int id, Country country)
        {
            if (id != country.Id)
            {
                return BadRequest();
            }

            _context.Entry(country).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CountryExists(country.CountryName))
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

        [HttpPost("bulk", Name = "PostCountries")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Country> PostCountries(IEnumerable<Country> countries)
        {
            this._context.Countries.AddRange(countries);

            this._context.SaveChanges();

            return this.CreatedAtAction(nameof(this.PostCountries), new { count = countries.Count() }, countries);
        }

        // POST: api/Countries
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Country>> PostCountry(Country country)
        {
            if (CountryExists(country.CountryName))
            {
                return Conflict("Le pays \""+ country.CountryName +"\" existe déjà");
            }
            else
            {
                _context.Countries.Add(country);
                await _context.SaveChangesAsync();
                return CreatedAtAction(nameof(GetCountry), new { id = country.Id }, country);
            }
        }

        // DELETE: api/Countries/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCountry(int id)
        {
            var country = await _context.Countries.FindAsync(id);
            if (country == null)
            {
                return NotFound();
            }

            _context.Countries.Remove(country);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CountryExists(string name)
        {
            return _context.Countries.Any(e => e.CountryName.ToLower() == name.ToLower());
        }
    }
}
