using Microsoft.AspNetCore.Http;
using PatchesToneLib.Application.Interfaces;
using PatchesToneLib.Application.Patches.Models;
using PatchesToneLib.Common.Files;
using PatchesToneLib.Domain.Patches;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatchesToneLib.Application.Patches.Commands.CreatePatch
{
   public class CreatePatchCommand : ICreatePatchCommand
    {
        private readonly IDatabaseService _db;
        private readonly IFileService _fileService;

        public CreatePatchCommand(IDatabaseService db,
            IFileService fileService)
        {
            _db = db;
            _fileService = fileService;
        }

        public void Execute(PatchModel patchModel, IFormFile file) {

            var patch = new Patch
            {
                Name = patchModel.Name,
                Artist = patchModel.Artist,
                Genre = patchModel.Genre,
                File = _fileService.ConvertFileToByteArray(file),
                FileName = file.FileName,
                Model = patchModel.Model
            };
            _db.Patches.Add(patch);
            _db.Save();
        }
    }
}
