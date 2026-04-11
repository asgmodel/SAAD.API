using AutoGenerator.Repositories.Base;
using LAHJA.API.Data;
using SADA.API.Models;
using Microsoft.AspNetCore.Identity;
using System;
using V1.BPR.Layers.Base;

namespace V1.Repositories.Base
{
    public sealed class BaseBPRRepository<T> : TBaseBPRRepository<ApplicationUser, IdentityRole, string, T>, IBPRLayer<T, T>, IBaseRepository<T> where T : class
    {
        public BaseBPRRepository(LahjaDataContext db, ILoggerFactory logger) : base(db, logger)
        {
        }
    }
}