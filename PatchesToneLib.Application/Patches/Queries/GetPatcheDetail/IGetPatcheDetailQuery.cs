using System;
using System.Collections.Generic;
using System.Text;

namespace PatchesToneLib.Application.Patches.Queries.GetPatcheDetail
{
    public interface IGetPatcheDetailQuery
    {
        PatcheDetailModel Execute(int PatcheID);
    }
}
