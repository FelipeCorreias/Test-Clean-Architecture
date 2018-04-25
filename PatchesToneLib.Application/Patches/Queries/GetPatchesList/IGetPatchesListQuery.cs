using System;
using System.Collections.Generic;
using System.Text;

namespace PatchesToneLib.Application.Patches.Queries.GetPatchesList
{
   public interface IGetPatchesListQuery
    {
        List<PatchesListItemModel> Execute();
    }
}
