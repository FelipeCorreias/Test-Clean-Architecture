using PatchesToneLib.Application.Interfaces;
using PatchesToneLib.Application.Patches.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatchesToneLib.Application.Patches.Commands.UpdatePatch
{
    public class UpdatePatchCommand : IUpdatePatchCommand
    {
        private readonly IDatabaseService _db;

        public UpdatePatchCommand(IDatabaseService db)
        {
            _db = db;
        }

        public void Execute(PatchModel patchModel) {
            var patch = _db.Patches.Where(p => p.Id == patchModel.Id).Select(p => p).Single();
            patch.Name = patchModel.Name;
            patch.Genre = patchModel.Genre;
            patch.Artist = patchModel.Artist;
            patch.Model = patchModel.Model;
            patch.Author = patchModel.Author;
            _db.Save();
        }

    }
}
