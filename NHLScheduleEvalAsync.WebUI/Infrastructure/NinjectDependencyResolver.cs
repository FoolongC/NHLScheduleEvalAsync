using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Ninject;
using Moq;
using NHLScheduleEval.Domain.Abstract;
using NHLScheduleEval.Domain.Entities;
using NHLScheduleEval.Domain.Concrete;

namespace NHLScheduleEval.WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        private void AddBindings()
        {
            //kernel.Bind<ITeamB2BComparisonRepository>().To<GameB2BComparisonRepository>();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
    }
}