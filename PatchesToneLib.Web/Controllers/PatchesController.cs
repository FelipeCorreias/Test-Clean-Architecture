using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatchesToneLib.Application.Patches.Commands.CreatePatch;
using PatchesToneLib.Application.Patches.Models;
using PatchesToneLib.Application.Patches.Queries.GetPatchDetail;
using PatchesToneLib.Application.Patches.Queries.GetPatchesList;

namespace PatchesToneLib.Web.Controllers
{
    [Produces("application/json")]
    [Route("api/Patches")]
    public class PatchesController : Controller
    {

        private readonly IGetPatchesListQuery _getPatches;
        private readonly IGetPatchDetailQuery _getPatch;
        private readonly ICreatePatchCommand _createPatch;

        public PatchesController(IGetPatchesListQuery getPatches,
            IGetPatchDetailQuery getPatch,
            ICreatePatchCommand createPatch)
        {
            _getPatches = getPatches;
            _getPatch = getPatch;
            _createPatch = createPatch;
        }

        // GET: api/Patch
        [HttpGet]
        public IEnumerable<PatchModel> Get()
        {
            return _getPatches.Execute();
        }

        // GET: api/Patches/5
        [HttpGet("{id}", Name = "Get")]
        public PatchModel Get(int id)
        {
            return _getPatch.Execute(id);
        }

        // POST: api/Patches
        [HttpPost]
        public void Post([FromBody]PatchModel patch)
        {
            _createPatch.Execute(patch);
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
