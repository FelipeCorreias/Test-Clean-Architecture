using PatchesToneLib.Application.Interfaces;
using PatchesToneLib.Application.Patches.Models;
using PatchesToneLib.Domain.Patches;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatchesToneLib.Application.Patches.Commands.CreatePatch
{
   public class CreatePatchCommand : ICreatePatchCommand
    {
        private readonly IDatabaseService _db;

        public CreatePatchCommand(IDatabaseService db)
        {
            _db = db;
        }

        public void Execute(PatchModel patchModel) {
            var patch = new Patch
            {
                Name = patchModel.Name,
                Artist = patchModel.Artist,
                Genre = patchModel.Genre
            };
            _db.Patches.Add(patch);
            _db.Save();
        }
    }
}
