using PatchesToneLib.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatchesToneLib.Application.Patches.Commands.DeletePatch
{
    public class DeletePatchCommand : IDeletePatchCommand
    {
        private readonly IDatabaseService _db;

        public DeletePatchCommand(IDatabaseService db)
        {
            _db = db;
        }

        public void Execute(int patchID)
        {
            var patch = _db.Patches.Where(p => p.Id == patchID).Select(p => p).Single();
            _db.Patches.Remove(patch);
            _db.Save();
        }
    }
}
