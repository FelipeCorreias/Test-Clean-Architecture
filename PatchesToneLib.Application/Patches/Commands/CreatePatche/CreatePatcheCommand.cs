using PatchesToneLib.Application.Interfaces;
using PatchesToneLib.Domain.Patches;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatchesToneLib.Application.Patches.Commands.CreatePatche
{
   public class CreatePatcheCommand : ICreatePatcheCommand
    {
        private readonly IDatabaseService _db;

        public CreatePatcheCommand(IDatabaseService db)
        {
            _db = db;
        }

        public void Execute(CreatePatcheModel model) {
            var patche = new Patche
            {
                Name = model.Name,
                Artist = model.Artist,
                Genre = model.Genre
            };
            _db.Patches.Add(patche);
        }
    }
}
