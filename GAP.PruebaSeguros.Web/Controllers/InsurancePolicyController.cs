using GAP.PruebaSeguros.Application.BusinessLogic;
using GAP.PruebaSeguros.Application.Helpers;
using GAP.PruebaSeguros.CrossCutting;
using GAP.PruebaSeguros.Domain.Models;
using GAP.PruebaSeguros.Domain.Services.CoveringTypes;
using GAP.PruebaSeguros.Domain.Services.InsurancePolicies;
using System;
using System.Linq;
using System.Web.Http;


namespace GAP.PruebaSeguros.Web.Controllers
{
    [RoutePrefix("api/InsurancePolicy")]
    public class InsurancePolicyController : ApiController
    {
        private CommonHelper helper;        

        public InsurancePolicyController()
        {
            helper = new CommonHelper();
        }

        [HttpGet]
        [Route("{id:int}")]
        public IHttpActionResult Get(int id)
        {
            var policy = IoCFactory.Resolve<IInsurancePolicyServices>().GetInsurancePolicy(id).FirstOrDefault();
           
            if (policy == null)
            {
                return NotFound();
            }

            policy = helper.CompleteInsurance(policy);
           
            return Ok(policy);
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult Post(InsurancePolicy insurancePolicy)
        {
            try
            {
                if(!helper.ValidInsurancePolicy(insurancePolicy))
                {
                    return BadRequest("High Risk Insurance Policy must have covering percentage below 50%");
                }
                
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
                if (!helper.ValidInsurancePolicy(insurancePolicy))
                {
                    return BadRequest("High Risk Insurance Policy must have covering percentage below 50%");
                }

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