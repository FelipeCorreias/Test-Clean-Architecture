using PatchesToneLib.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatchesToneLib.Application.Patches.Queries.GetPatchFile
{
   public class GetPatchFileQuery : IGetPatchFileQuery
    {
        private readonly IDatabaseService _db;

        public GetPatchFileQuery(IDatabaseService db)
        {
            _db = db;
        }

        public byte[] Execute(int patchID)
        {
            var patch = _db.Patches.Where(p => p.Id == patchID).Single();
            return patch.File;
        }
    }
}
