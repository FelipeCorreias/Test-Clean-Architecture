using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatchesToneLib.Application.Patches.Commands.CreatePatch;
using PatchesToneLib.Application.Patches.Commands.DeletePatch;
using PatchesToneLib.Application.Patches.Commands.UpdatePatch;
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
        private readonly IUpdatePatchCommand _updatePatch;
        private readonly IDeletePatchCommand _deletePatch;

        public PatchesController(IGetPatchesListQuery getPatches,
            IGetPatchDetailQuery getPatch,
            ICreatePatchCommand createPatch,
            IUpdatePatchCommand updatePatch,
            IDeletePatchCommand deletePatch)
        {
            _getPatches = getPatches;
            _getPatch = getPatch;
            _createPatch = createPatch;
            _updatePatch = updatePatch;
            _deletePatch = deletePatch;
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
        public void Post([FromBody]PatchModel patchModel)
        {
            _createPatch.Execute(patchModel);
        }

        // PUT: api/Patches/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]PatchModel patchModel)
        {
            patchModel.Id = id;
            _updatePatch.Execute(patchModel);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _deletePatch.Execute(id);
        }
    }
}
