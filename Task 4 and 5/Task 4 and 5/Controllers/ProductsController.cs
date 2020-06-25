﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Task_4_and_5.Models;

namespace Task_4_and_5.Controllers
{
  
    public class ProductsController : ApiController
    {
    }
 
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
        //public static void Register(HttpConfiguration config)
        //{
        //    config.Filters.Add(new RequireHttpsAttribute());
        //}

    }
}

