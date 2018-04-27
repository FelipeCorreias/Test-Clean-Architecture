using System;
using System.Collections.Generic;
using System.Text;

namespace PatchesToneLib.Application.Patches.Commands.DeletePatch
{
    public interface IDeletePatchCommand
    {
        void Execute(int patchID);
    }
}
