using PatchesToneLib.Domain.Common;
using System;

namespace PatchesToneLib.Domain.Patches
{
    public class Patch : Entity
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }
        public string FileName { get; set; }
        public byte[] File { get; set; }
        public string Model { get; set; }
        public bool IsApproved { get; set; } = false;
        public string Author { get; set; }
    }
}
