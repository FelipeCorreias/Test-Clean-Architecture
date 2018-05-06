using PatchesToneLib.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatchesToneLib.Application.Patches.Commands.ApprovePatch
{
   public class ApprovePatchCommand : IApprovePatchCommand
    {
        private readonly IDatabaseService _db;

        public ApprovePatchCommand(IDatabaseService db)
        {
            _db = db;
        }

        public void Execute(int patchID)
        {
            var patch = _db.Patches.Where(p => p.Id == patchID).Select(p => p).Single();
            patch.IsApproved = true;
            _db.Save();
        }
    }
}
