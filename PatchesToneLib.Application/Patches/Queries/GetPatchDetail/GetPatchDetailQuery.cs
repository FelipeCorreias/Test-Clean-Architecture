using PatchesToneLib.Application.Interfaces;
using PatchesToneLib.Application.Patches.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatchesToneLib.Application.Patches.Queries.GetPatchDetail
{
    public class GetPatchDetailQuery : IGetPatchDetailQuery
    {
        private readonly IDatabaseService _db;

        public GetPatchDetailQuery(IDatabaseService db)
        {
            _db = db;
        }

        public PatchModel Execute(int patchID)
        {
            var patch = _db.Patches.Where(p => p.Id == patchID).Select(p => new PatchModel()
            {
                Id = p.Id,
                Name = p.Name,
                Artist = p.Artist,
                Genre = p.Genre
            }).Single();

            return patch;
        }
    }
}
