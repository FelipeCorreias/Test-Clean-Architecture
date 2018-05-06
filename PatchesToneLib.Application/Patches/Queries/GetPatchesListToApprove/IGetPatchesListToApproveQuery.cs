using PatchesToneLib.Application.Patches.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatchesToneLib.Application.Patches.Queries.GetPatchesToApproveList
{
   public interface IGetPatchesListToApproveQuery
    {
        List<PatchModel> Execute();
    }
}
