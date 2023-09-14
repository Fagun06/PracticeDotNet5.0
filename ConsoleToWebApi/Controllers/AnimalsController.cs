﻿using ConsoleToWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleToWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        private List<AnimalModel> animals= null;
        public AnimalsController()
        {
             animals = new List<AnimalModel>()
            {
            new AnimalModel() { Id= 1 , Name = "Dog"},
            new AnimalModel() { Id = 2, Name = "Lion" }

            };
        }
        [Route("",Name ="All")]
        public IActionResult GetAnimal()
        {

            return Ok(animals);
        }

        [Route("test")]
        public IActionResult GetAnimalsTest()
        {
         
            return AcceptedAtRoute("All");
        }

        [Route("{name}")]
        public IActionResult GetAnimalsByName(string name)
        {
            if(!name.Contains("ABC"))
            {
                return BadRequest();
            }
            

            return Ok(animals);
        }

        [Route("{id:int}")]
        public IActionResult GetAnimalsById(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }


            return Ok(animals.FirstOrDefault(x=>x.Id==id));
        }

        [HttpPost("")]
        public IActionResult GetAnimal (AnimalModel animal)
        {
            animals.Add(animal);
            return CreatedAtAction("GetAnimalsById" , new { id = animal.Id },animal);
        }
    }
}
