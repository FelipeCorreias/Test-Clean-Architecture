using System;
using System.Collections.Generic;
using System.Text;

namespace PatchesToneLib.Application.Patches.Commands.ApprovePatch
{
  public interface IApprovePatchCommand
    {
        void Execute(int patchID);
    }
}
