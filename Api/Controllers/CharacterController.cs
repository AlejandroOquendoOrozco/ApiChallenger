using DataAcces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entitys;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        // GET: api/<CharacterController>
        [HttpGet]
        public IEnumerable<Characters> Get()
        {
            using(var dbContext=new ApiDisneyContext())
            {
                return dbContext.TCharacter.ToList();
            }
            
        }
        [HttpGet ("{name}")]
        public Characters Get(string name)
        {
            using (var dbContext = new ApiDisneyContext())
            {
             var CharacterName= dbContext.TCharacter.FirstOrDefault(x=> x.Name.Equals(name));
                return CharacterName;
            }

        }
        [HttpGet("{age}")]
        public Characters Get(int age)
        {
            using (var dbContext = new ApiDisneyContext())
            {
               var ChararacterAge= dbContext.TCharacter.FirstOrDefault(x => x.Age.Equals(age));
                return ChararacterAge;
            }

        }
        [HttpPost]
        public Characters Post(Characters character)
        {
            using (var dbContext = new ApiDisneyContext())
            {
                dbContext.TCharacter.Add(character);
                dbContext.SaveChanges();
                return character;

            } 

        }


        // PUT api/<CharacterController>/5
        [HttpPut]
        public Characters Put(Characters character)
        {
            using (var dbContext = new ApiDisneyContext())
            {
                var Characterput = dbContext.TCharacter.FirstOrDefault(x => x.IdCharacters.Equals(character.IdCharacters));
                Characterput.Name = character.Name;
                Characterput.History = character.History;
                Characterput.Age = character.Age;
                Characterput.Weight = character.Weight;
                dbContext.SaveChanges();
                return character;

            }

        }

        // DELETE api/<CharacterController>/5
        [HttpDelete]
        public bool Delete(string id)
        {
            using (var dbContext = new ApiDisneyContext())
            {
                var CharacterDelete = dbContext.TCharacter.FirstOrDefault(x => x.IdCharacters.Equals(id));
                dbContext.TCharacter.Remove(CharacterDelete);
                
                dbContext.SaveChanges();
                return true;

            }

        }
    }
}
