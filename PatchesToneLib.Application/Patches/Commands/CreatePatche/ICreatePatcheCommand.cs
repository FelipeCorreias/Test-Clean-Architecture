using System;
using System.Collections.Generic;
using System.Text;

namespace PatchesToneLib.Application.Patches.Commands.CreatePatche
{
   public interface ICreatePatcheCommand
    {
        void Execute(CreatePatcheModel model);
    }
}
