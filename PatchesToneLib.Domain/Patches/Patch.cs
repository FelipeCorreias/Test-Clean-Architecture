using PatchesToneLib.Domain.Common;
using System;

namespace PatchesToneLib.Domain.Patches
{
    public class Patch : Entity
    {
        private bool _isApproved;
        public string Name { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }
        public string FileName { get; set; }
        public byte[] File { get; set; }
        public string Model { get; set; }
        public bool IsApproved
        {
            get
            {
                return _isApproved;
            }
            set
            {
                IfNewNotApproved();
                _isApproved = value;

            }
        }

        private void IfNewNotApproved() {
            if (Id == 0) {
                IsApproved = false;
            }
        }


    }
}
