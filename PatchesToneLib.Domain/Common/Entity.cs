using System;
using System.Collections.Generic;
using System.Text;

namespace PatchesToneLib.Domain.Common
{
    public class Entity
    {
        public int Id { get; set; }
        public DateTime Updated { get; private set; }
        public DateTime Created { get; private set; }

    }
}
