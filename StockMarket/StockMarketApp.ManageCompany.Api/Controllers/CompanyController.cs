using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using StockMarketApp.ManageCompany.Api.Models;
using StockMarketApp.ManageCompany.Api.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarketApp.ManageCompany.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   // [EnableCors("AllowOrigin")]
    public class CompanyController : Controller
    {
        private readonly ICompanyService service=new CompanyService();

        //public CompanyController(ICompanyService companyService)
        //{
        //    service = companyService;
        //}
       // stockmarketdbContext db = new stockmarketdbContext();
        [Route("~/api/Add")]
        [HttpPost("Add")]
        public async Task<ActionResult> Add([FromBody] Company item)
        {


            service.AddCompany(item);
            return Ok();

        }
        [HttpGet]
        [Route("GetCompanies")]
        public IActionResult GetCompanies()
        {
            List<Company> cmp = new List<Company>();
            cmp = service.GetCompanies();
            if (cmp != null)
            {
                return Ok(cmp);
            }
            else
            {
                return NotFound("No Company");
            }
        }
        [HttpPut]
        [Route("EditCompany")]
        public IActionResult EditCompany(Company item)
        {
            service.EditCompany(item);
            return Ok();
        }
        [HttpGet]
        [Route("GetCompanyDetails/{id}")]
        public IActionResult GetCompanyDetails(int id)
        {
            Company cmp = service.GetCompanyDetails(id);
            if (cmp != null)
            {
                return Ok(cmp);
            }
            else
            {
                return NotFound("Invalid Company ID");
            }
        }
        [HttpGet]
        [Route("GetCompanyDetailsByName/{name}")]
        public IActionResult GetCompanyDetailsByName(string name)
        {
            Company cmp = service.GetCompanyDetailsByName(name);
            if (cmp != null)
            {
                return Ok(cmp);
            }
            else
            {
                return NotFound("Invalid Company name");
            }
        }
        [HttpGet]
        [Route("GetMatchingCompanies/{word}")]
        public  IActionResult GetMatchingCompanies(string word)
        {
            List<Company> cmp = new List<Company>();
             cmp = service.GetMatchingCompanies(word);
            if (cmp != null)
            {
                return Ok(cmp);
            }
            else
            {
                return NotFound("Invalid Company Name");
            }
        }
        [HttpDelete]
        [Route("DeleteCompany/{id}")]
        public IActionResult DeleteCompany(int id)
        {
            service.DeleteCompany(id);
            return Ok();
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [Route("GetMatchingIpoDetails/{name}")]
        public IActionResult GetMatchingIpoDetails(string name)
        {
            List<Ipodetail> cmp = new List<Ipodetail>();
            cmp = service.GetMatchingIpoDetails(name);
            if (cmp != null)
            {
                return Ok(cmp);
            }
            else
            {
                return NotFound("Invalid Company ID");
            }
        }
    }
}
