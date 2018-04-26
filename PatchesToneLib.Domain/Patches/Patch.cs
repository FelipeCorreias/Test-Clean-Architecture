using PatchesToneLib.Domain.Common;
using System;

namespace PatchesToneLib.Domain.Patches
{
    public class Patch : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }
        
    }
}
