using PatchesToneLib.Application.Interfaces;
using PatchesToneLib.Application.Patches.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatchesToneLib.Application.Patches.Queries.GetPatchesListByModel
{
   public class GetPatchesListByModelQuery : IGetPatchesListByModelQuery
    {
        private readonly IDatabaseService _db;

        public GetPatchesListByModelQuery(IDatabaseService db)
        {
            _db = db;
        }

        public List<PatchModel> Execute(string model)
        {
            var patches = _db.Patches.Where(p => p.IsApproved && p.Model.Contains(model)).Select(p => new PatchModel()
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
