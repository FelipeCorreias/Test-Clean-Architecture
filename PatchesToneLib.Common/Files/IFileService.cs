using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatchesToneLib.Common.Files
{
   public interface IFileService
    {
        byte[] ConvertFileToByteArray(IFormFile file);
    }
}
