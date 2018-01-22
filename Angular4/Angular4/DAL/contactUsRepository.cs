using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Angular4.Models;
using Angular4.DAL;

namespace Angular4.DAL
{
    public class contactUsRepository
    {
        private MorgoniteEntities _morgoniteContext;

        public  contactUsRepository(MorgoniteEntities morgoniteEntities)
        {
            _morgoniteContext = morgoniteEntities;
        }
        public List<contactUsModel> GetContactDetails()
        {
            var contactDetails = _morgoniteContext.customerDetails.ToList();
            return contactDetails.Select(d => new contactUsModel()
            {
                Name = d.name,
                Address = d.address,
                EmailId = d.emailId,
                Message = d.message,
                PhoneNumber = d.phoneNumber
            }).ToList();

            
        }
    }
}