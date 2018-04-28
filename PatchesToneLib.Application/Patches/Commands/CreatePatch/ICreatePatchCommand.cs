using Microsoft.AspNetCore.Http;
using PatchesToneLib.Application.Patches.Models;
using System;
using System.Collections.Generic;
using System.Text;
 
namespace PatchesToneLib.Application.Patches.Commands.CreatePatch
{
   public interface ICreatePatchCommand
    {
        void Execute(PatchModel patchModel, IFormFile file);
    }
}
