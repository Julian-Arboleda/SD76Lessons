﻿using _13_RestaurantRater.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace _13_RestaurantRater.Controllers
{
    // API controller just deals with data
    // MVC controller (red badge) also returns views (HTML/CSS/JS)
    public class RestaurantController : ApiController
    {
        private readonly RestaurantDbContext _context = new RestaurantDbContext();

        // C
        [HttpPost]
        public async Task<IHttpActionResult> PostRestaurant(Restaurant model)
        {
            if (ModelState.IsValid)
            {
                _context.Restaurants.Add(model);
                await _context.SaveChangesAsync();

                return Ok(); // 200
            }

            return BadRequest(ModelState); //400
        }

        // R
        [HttpGet]
        public async Task<IHttpActionResult> GetAllRestaurants()
        {
            List<Restaurant> restaurants = await _context.Restaurants.ToListAsync();

            // Select can convert a list of one type of thing into a list of another type of thing
            List<RestaurantListItem> restaurantList = restaurants.Select(r => new RestaurantListItem()
            {
                Name = r.Name,
                Address = r.Address,
                Rating = r.Rating,
                Id = r.Id
            }).ToList();
            return Ok(restaurantList);



            // hypothetical Select() example:
            //  List<string> names = users.Select(u => u.Name).ToList();
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetRestaurantById(int id)
        {
            Restaurant restaurant = await _context.Restaurants.FindAsync(id);

            if (restaurant == default)
            {
                return NotFound(); // 404
            }

            
            RestaurantDetail restaurantDetail = new RestaurantDetail()
            {
                Id = restaurant.Id,
                Name = restaurant.Name,
                Address = restaurant.Address,
                Owner = restaurant.Owner,
                Rating = restaurant.Rating,
                AverageFoodScore = restaurant.AverageFoodScore
            };

            return Ok(restaurantDetail); //200
        }

        


        // Race condition - a situation where two async tasks happening, not sure which one will finish first, how the code runs depends on which finishes first.(we shouldn't ever have to deal with that) -- try to avoid by waiting for both conditions to await true

        // U
        [HttpPut]
        public async Task<IHttpActionResult> UpdateRestaurant([FromUri] int id, [FromBody] Restaurant model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Restaurant restaurant = await _context.Restaurants.FindAsync(id);

            if (restaurant == null)
            {
                return NotFound();
            }

            restaurant.Name = model.Name;
            restaurant.Address = model.Address;
           // restaurant.Rating = model.Rating;

            await _context.SaveChangesAsync();
         
            return Ok();
        }


        // D


        [HttpDelete]
        public async Task<IHttpActionResult> DeleteRestaurant(int id)
        {
            Restaurant restaurant = await _context.Restaurants.FindAsync(id);

            if (restaurant == default)
            {
                return NotFound(); // 404
            }

            // Remove the restaurant from our C# representation of the DB (aka the context)
            _context.Restaurants.Remove(restaurant);

            // Make sure when we save our changes that exactly one thing changed in the DB
            // This is where the changes we made to our context are applied to the actual DB
            if (await _context.SaveChangesAsync() == 1)
            {

                return Ok(); //200
            }
            // If it hasn't either deleted the object or returned 404, something is seriously wrong!
            return InternalServerError(); //500



        }
    }
}
            /* [HttpDelete]
                public async Task<IHttpActionResult> DeleteRestaurantByID(int id)
                {
                    Restaurant restaurant = await _context.Restaurants.FindAsync(id);

                    if (restaurant == default)
                    {
                        return NotFound(); // 404
                    }
                    else
                    {
                        _context.Restaurants.Remove(restaurant);
                        await _context.SaveChangesAsync();
                    }
                    return Ok();
                } --our delete method*/

