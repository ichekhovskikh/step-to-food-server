﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace StepToFoodServer.Controllers
{
    [Route("api/[controller]")]
    public class FoodController : Controller
    {
        // GET api/food
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "food1", "food2" };
        }

        // GET api/food/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "food";
        }

        // POST api/food
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/food/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/food/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}