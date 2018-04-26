using PatchesToneLib.Application.Patches.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatchesToneLib.Application.Patches.Commands.UpdatePatch
{
    public interface IUpdatePatchCommand
    {
        void Execute(PatchModel patchModel);
    }
}
