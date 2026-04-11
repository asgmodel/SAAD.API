using AutoGenerator;
using AutoGenerator.Conditions;
using AutoGenerator.Notifications;
using AutoMapper;
using LAHJA.API.Data;
using System;
using V1.BPR.Layers.Base;

namespace V1.Validators.Conditions
{
    public class TFactoryInjector : TBaseFactoryInjector, ITFactoryInjector
    {
        private readonly LahjaDataContext _context;
        public TFactoryInjector(IMapper mapper, IAutoNotifier notifier, LahjaDataContext context) : base(mapper, notifier)
        {
            _context = context;
        }

        public LahjaDataContext Context => _context;
    // يمكنك حقن اي طبقة
    }
}