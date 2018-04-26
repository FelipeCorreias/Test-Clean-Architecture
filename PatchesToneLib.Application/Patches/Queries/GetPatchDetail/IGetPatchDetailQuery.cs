using PatchesToneLib.Application.Patches.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatchesToneLib.Application.Patches.Queries.GetPatchDetail
{
    public interface IGetPatchDetailQuery
    {
        PatchModel Execute(int PatcheID);
    }
}
