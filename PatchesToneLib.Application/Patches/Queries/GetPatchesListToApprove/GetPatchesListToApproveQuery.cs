using PatchesToneLib.Application.Interfaces;
using PatchesToneLib.Application.Patches.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatchesToneLib.Application.Patches.Queries.GetPatchesToApproveList
{
   public class GetPatchesListToApproveQuery : IGetPatchesListToApproveQuery
    {
        private readonly IDatabaseService _db;

        public GetPatchesListToApproveQuery(IDatabaseService db)
        {
            _db = db;
        }

        public List<PatchModel> Execute()
        {
            var patches = _db.Patches.Where(p => p.IsApproved == false).Select(p => new PatchModel()
            {
                Id = p.Id,
                Name = p.Name,
                Genre = p.Genre,
                Artist = p.Artist,
                FileName = p.FileName,
                Model = p.Model,
                Author = p.Author
            });

            return patches.ToList();
        }

    }
}
