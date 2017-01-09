using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sdvcWebapp.Models;
using sdvcWebapp.Repository;
using sdvcWebapp.DataTransferObjects;
using System.Linq;

namespace sdvcWebapp.Controllers
{
    public class KeywordController : Controller
    {
        private IKeywordRepository _kwRepo;
        private IVSORepository _vsoRepo;
        public KeywordController(IKeywordRepository kwRepository, IVSORepository vsorepo)
        {
            _kwRepo = kwRepository;
            _vsoRepo = vsorepo;
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
            _kwRepo.Add(kwToAdd);
            _kwRepo.PersistChanges();
            Uri returnUri = new Uri($"{HttpContext.Request.Scheme}://{HttpContext.Request.Host}{HttpContext.Request.Path}");
            return Created(returnUri,keywordDto); //TODO: Fix this

            //return $"{request.Scheme}://{request.Host}{request.Path}";
        }

        [HttpGet]
        [RouteAttribute("keyword/{keyword}")] //Should match the route so you can do sdvc.org/keyword/keywordhere
        public IActionResult GetVSOsByKeyword(string keyword)
        {
            if(keyword != null && keyword.Length < 100)
            {
            // List<VSO> vsos = _vsoRepo.GetVSOsByKeyword(keyword);
            IList<Keyword> vsos = _kwRepo.GetAll();
            return Json(vsos);
            }
            else
            {
                return NotFound();
            }
        }
    }
}