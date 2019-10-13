using GAP.PruebaSeguros.CrossCutting;
using GAP.PruebaSeguros.Domain.Models;
using GAP.PruebaSeguros.Domain.Services.InsurancePolicies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace GAP.PruebaSeguros.Application.Controllers
{
    [RoutePrefix("api/[controller]")]
    public class InsurancePolicyController : ApiController
    {
        [HttpGet]
        [Route("{id:int}")]
        public IHttpActionResult Get(int id)
        {
            var policy = IoCFactory.Resolve<IInsurancePolicyServices>().GetInsurancePolicy(id).FirstOrDefault();

            if(policy == null)
            {
               return NotFound();
            }

            return Ok(policy);
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult Post(InsurancePolicy insurancePolicy)
        {
            try
            {
                var insurance = IoCFactory.Resolve<IInsurancePolicyServices>().CreateInsurancePolicy(insurancePolicy);
                return Created(new Uri(Request.RequestUri + insurance.Name), insurance);
            }
            catch (Exception)
            {
                return BadRequest();
            }                       
        }

        [HttpPut]
        [Route("")]
        public IHttpActionResult Put(InsurancePolicy insurancePolicy)
        {
            try
            {
                IoCFactory.Resolve<IInsurancePolicyServices>().UpdateInsurancePolicy(insurancePolicy);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        [Route("{id:int}")]
        public IHttpActionResult Delete(int id)
        {
            try
            {
                IoCFactory.Resolve<IInsurancePolicyServices>().DeleteInsurancePolicy(id);
                return Delete(id);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
