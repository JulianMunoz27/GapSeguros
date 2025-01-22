
using GAP.PruebaSeguros.CrossCutting;
using GAP.PruebaSeguros.Domain.Models;
using GAP.PruebaSeguros.Domain.Services.InsurancePolicies;
using GAP.PruebaSeguros.Web.Controllers;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Results;
using Unity;

namespace GAP.PruebaSeguros.Test.UnitTest.Controller
{
    public class InsurancePolicyControllerTest
    {
        protected UnityContainer Container;

        [SetUp]
        public void Init()
        {
            Container = new UnityContainer();
        }

        [Test]
        public void Get_InsurancePolicy_ShouldReturnOk()
        {
            var id = 1;
            var list = new List<InsurancePolicy>();


            var service = new Mock<IInsurancePolicyServices>();
            service.Setup(i => i.GetInsurancePolicy(id)).Returns(list.AsQueryable());

            var controller = new InsurancePolicyController();
            var result = controller.Get(id);

            Assert.AreEqual(result.GetType(), typeof(OkNegotiatedContentResult<InsurancePolicy>));    
        }

        [Test]
        public void Post_InsurancePolicy_ShouldRetornCreated()
        {
            var insurance = new InsurancePolicy()
            {
                Id = 1,
                Name = "Test Policy",
                Description = "Test Description",
                StartDate = DateTime.Now,
                CoveringMonths = 12,
                Price = "1000 USD",
                RiskType = "Low",
                CoveringTypes = "Fire, Theft",
                CoveringPercentage = 80
            }; ;

            var service = new Mock<IInsurancePolicyServices>();
            var foo = service.Setup(i => i.CreateInsurancePolicy(insurance)).Returns(new InsurancePolicy());

            var controller = new InsurancePolicyController();
            var result = controller.Post(insurance);

            Assert.AreEqual(result.GetType(), typeof(CreatedNegotiatedContentResult<InsurancePolicy>));
        }
    }
}
