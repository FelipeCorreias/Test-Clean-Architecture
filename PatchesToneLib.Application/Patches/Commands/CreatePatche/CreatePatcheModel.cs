using System;
using System.Collections.Generic;
using System.Text;

namespace PatchesToneLib.Application.Patches.Commands.CreatePatche
{
   public class CreatePatcheModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }
    }
}
