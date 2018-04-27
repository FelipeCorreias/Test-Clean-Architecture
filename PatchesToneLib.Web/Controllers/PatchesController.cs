using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatchesToneLib.Application.Patches.Commands.CreatePatch;
using PatchesToneLib.Application.Patches.Commands.DeletePatch;
using PatchesToneLib.Application.Patches.Commands.UpdatePatch;
using PatchesToneLib.Application.Patches.Models;
using PatchesToneLib.Application.Patches.Queries.GetPatchDetail;
using PatchesToneLib.Application.Patches.Queries.GetPatchesList;
using PatchesToneLib.Application.Patches.Queries.GetPatchFile;

namespace PatchesToneLib.Web.Controllers
{
    [Produces("application/json")]
    [Route("api/Patches")]
    public class PatchesController : Controller
    {

        private readonly IGetPatchesListQuery _getPatches;
        private readonly IGetPatchDetailQuery _getPatch;
        private readonly IGetPatchFileQuery _getPatchFile;

        private readonly ICreatePatchCommand _createPatch;
        private readonly IUpdatePatchCommand _updatePatch;
        private readonly IDeletePatchCommand _deletePatch;
        

        public PatchesController(IGetPatchesListQuery getPatches,
            IGetPatchDetailQuery getPatch,
            IGetPatchFileQuery getPatchFile,
            ICreatePatchCommand createPatch,
            IUpdatePatchCommand updatePatch,
            IDeletePatchCommand deletePatch)
        {
            _getPatches = getPatches;
            _getPatch = getPatch;
            _getPatchFile = getPatchFile;

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

        // GET: api/Patches/5
        [HttpGet("{id}/File", Name = "GetFile")]
        public FileResult Get(int id,string file)
        {
            var patchFile = _getPatchFile.Execute(id);
            var patch = _getPatch.Execute(id);
            return File(patchFile,"text/plain", patch.FileName);
        }

        // POST: api/Patches
        [HttpPost]
        public void Post(PatchModel patchModel, IFormFile file)
        {
            _createPatch.Execute(patchModel, file);
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
