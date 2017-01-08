using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sdvcWebapp.Models;
using sdvcWebapp.Repository;
using sdvcWebapp.DataTransferObjects;

namespace sdvcWebapp.Controllers
{
    public class KeywordController : Controller
    {
        private IKeywordRepository _kwRepo;
        public KeywordController(IKeywordRepository kwRepository)
        {
            _kwRepo = kwRepository;
        }

        [HttpPost]
        public IActionResult Add([FromBody]KeywordDto keywordDto)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            //For testing purposes:
            Keyword kwToAdd = new Keyword();
            kwToAdd.kw = keywordDto.kw;
            int response = _kwRepo.Add(kwToAdd);
            if(response < 0)
            {
                return Content("Fail.");
            }
            else
            {
                return Ok();
            }
        }
    }
}