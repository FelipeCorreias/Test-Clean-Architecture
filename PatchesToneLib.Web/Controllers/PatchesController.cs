using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatchesToneLib.Application.Patches.Commands.ApprovePatch;
using PatchesToneLib.Application.Patches.Commands.CreatePatch;
using PatchesToneLib.Application.Patches.Commands.DeletePatch;
using PatchesToneLib.Application.Patches.Commands.UpdatePatch;
using PatchesToneLib.Application.Patches.Models;
using PatchesToneLib.Application.Patches.Queries.GetPatchDetail;
using PatchesToneLib.Application.Patches.Queries.GetPatchesList;
using PatchesToneLib.Application.Patches.Queries.GetPatchesListByModel;
using PatchesToneLib.Application.Patches.Queries.GetPatchesToApproveList;
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
        private readonly IGetPatchesListByModelQuery _getPatchesByModel;
        private readonly IGetPatchesListToApproveQuery _getPatchesToApprove;

        private readonly ICreatePatchCommand _createPatch;
        private readonly IUpdatePatchCommand _updatePatch;
        private readonly IDeletePatchCommand _deletePatch;
        private readonly IApprovePatchCommand _approvePatch;


        public PatchesController(IGetPatchesListQuery getPatches,
            IGetPatchDetailQuery getPatch,
            IGetPatchFileQuery getPatchFile,
            IGetPatchesListByModelQuery getPatchesByModel,
            IGetPatchesListToApproveQuery getPatchesToApprove,
            ICreatePatchCommand createPatch,
            IUpdatePatchCommand updatePatch,
            IDeletePatchCommand deletePatch,
            IApprovePatchCommand approvePatch)
        {
            _getPatches = getPatches;
            _getPatch = getPatch;
            _getPatchFile = getPatchFile;
            _getPatchesByModel = getPatchesByModel;
            _getPatchesToApprove = getPatchesToApprove;

            _createPatch = createPatch;
            _updatePatch = updatePatch;
            _deletePatch = deletePatch;
            _approvePatch = approvePatch;
        }

        // GET: api/Patches
        [HttpGet]
        public IEnumerable<PatchModel> Get()
        {
            return _getPatches.Execute();
        }

        // GET: api/Patches/Model/G1on
        [HttpGet("Model/{model}")]
        public IEnumerable<PatchModel> GetPatchesByModel(string model)
        {
            return _getPatchesByModel.Execute(model);
        }

        // GET: api/Patches/ToApprove
        [HttpGet("ToApprove")]
        public IEnumerable<PatchModel> GetPatchesToApprove()
        {
            return _getPatchesToApprove.Execute();
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

        // PUT: api/Patches/5/Approve
        [HttpPut("{id}/Approve")]
        public void Put(int id,string approve)
        {
            _approvePatch.Execute(id);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _deletePatch.Execute(id);
        }
    }
}
