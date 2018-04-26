using Microsoft.EntityFrameworkCore;
using PatchesToneLib.Domain.Patches;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatchesToneLib.Application.Interfaces
{
   public interface IDatabaseService
    {
        DbSet<Patch> Patches { get; set; }
        void Save();
    }
}
