using PatchesToneLib.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatchesToneLib.Application.Patches.Queries.GetPatcheDetail
{
    public class GetPatcheDetailQuery : IGetPatcheDetailQuery
    {
        private readonly IDatabaseService _db;

        public GetPatcheDetailQuery(IDatabaseService db)
        {
            _db = db;
        }

        public PatcheDetailModel Execute(int patcheID)
        {
            var patche = _db.Patches.Where(p => p.Id == patcheID).Select(p => new PatcheDetailModel()
            {
                Id = p.Id,
                Name = p.Name,
                Artist = p.Artist,
                Genre = p.Genre
            }).Single();

            return patche;
        }
    }
}
