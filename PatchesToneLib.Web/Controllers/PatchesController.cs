using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatchesToneLib.Application.Patches.Queries.GetPatcheDetail;
using PatchesToneLib.Application.Patches.Queries.GetPatchesList;

namespace PatchesToneLib.Web.Controllers
{
    [Produces("application/json")]
    [Route("api/Patches")]
    public class PatchesController : Controller
    {

        private readonly IGetPatchesListQuery _getPatchesList;
        private readonly IGetPatcheDetailQuery _getPatcheDetail;

        public PatchesController(IGetPatchesListQuery getPatchesList,
            IGetPatcheDetailQuery getPatcheDetail)
        {
            _getPatchesList = getPatchesList;
            _getPatcheDetail = getPatcheDetail;
        }

        // GET: api/Patches
        [HttpGet]
        public IEnumerable<PatchesListItemModel> Get()
        {
            return _getPatchesList.Execute();
        }

        // GET: api/Patches/5
        [HttpGet("{id}", Name = "Get")]
        public PatcheDetailModel Get(int id)
        {
            return _getPatcheDetail.Execute(id);
        }

        // POST: api/Patches
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Patches/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
