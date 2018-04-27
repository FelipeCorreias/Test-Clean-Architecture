using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PatchesToneLib.Common.Files
{
  public  class FileService : IFileService
    {
        public byte[] ConvertFileToByteArray(IFormFile file)
        {
            if (file.Length > 0)
            {
                using (var ms = new MemoryStream())
                {
                    file.CopyTo(ms);
                    var fileBytes = ms.ToArray();

                    return fileBytes;
                    //string s = Convert.ToBase64String(fileBytes);
                    // act on the Base64 data
                }
            }

            return null;
        }

    }
}
