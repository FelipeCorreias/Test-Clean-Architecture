using PatchesToneLib.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatchesToneLib.Application.Patches.Queries.GetPatchesList
{
   public class GetPatchesListQuery : IGetPatchesListQuery
    {
        private readonly IDatabaseService _db;

        public GetPatchesListQuery(IDatabaseService db)
        {
            _db = db;
        }

        public List<PatchesListItemModel> Execute()
        {
            var patches = _db.Patches.Select(p => new PatchesListItemModel()
            {
                Id = p.Id,
                Name = p.Name,
                Genre = p.Genre,
                Artist = p.Artist
            });

            return patches.ToList();
        }

    }
}
