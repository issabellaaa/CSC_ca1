﻿using ProductStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
namespace ProductStore.Controllers
{
    public class TalentsController : ApiController
    {
        static readonly TalentRepository repository = new TalentRepository();
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("api/talents")]
        public IEnumerable<Talent> GetAllTalents()
        {
            return repository.GetAll();
        }

        [Route("api/talents/{id:int}")]
        public Talent GetTalent(int id)
        {
            Talent item = repository.Get(id);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return item;
        }

        [HttpPost]
        [Route("api/talents")]
        public Talent AddTalent(Talent talent)
        {
            if (talent == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            repository.Add(talent);
            return talent;
        }

        [HttpPut]
        [Route("api/talents/{id}")]
        public Talent EditTalent(int id, Talent talent)
        {
            if (talent == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            talent.Id = id;
            repository.Update(talent);
            return talent;
        }

        [HttpDelete]
        [Route("api/talents/{id}")]
        public string DeleteTalent(int id)
        {

            repository.Remove(id);
            return "Deleted " + id;
        }
    }
}
