using PatchesToneLib.Application.Patches.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatchesToneLib.Application.Patches.Queries.GetPatchesListByModel
{
   public interface IGetPatchesListByModelQuery
    {
        List<PatchModel> Execute(string model);
    }
}
