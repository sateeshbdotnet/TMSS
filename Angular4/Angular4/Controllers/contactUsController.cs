using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Angular4.DAL;
using Angular4.Models;

namespace Angular4.Controllers

{
    
    public class contactUsController : ApiController
    {
        private contactUsRepository _contractUsRepository;

        
        public contactUsController()
        {
            _contractUsRepository = new contactUsRepository(new MorgoniteEntities());
        }
        [HttpGet]
        public IHttpActionResult getContractDetails()
        {
            List<contactUsModel> List = _contractUsRepository.GetContactDetails();
            return Ok(List);
        }

    }
}
