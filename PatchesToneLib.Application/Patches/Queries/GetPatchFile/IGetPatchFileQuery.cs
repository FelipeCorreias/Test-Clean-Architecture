using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace PatchesToneLib.Application.Patches.Queries.GetPatchFile
{
   public interface IGetPatchFileQuery
    {
        byte[] Execute(int patchID);
    }
}
