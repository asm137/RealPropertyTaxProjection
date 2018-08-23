using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Intangic.RPTP.Business.Impl;
using Intangic.RPTP.Business.Interfaces;

namespace Intangic.RPTP.Factory
{
    public class BusinessDelegateFactory
    {
        private static BusinessDelegateFactory factory;

        public static BusinessDelegateFactory GetInstance() {
            if (factory == null)
                factory = new BusinessDelegateFactory();

            return factory;
        }

        public IRealPropertyTaxProjectionService GetRealPropertyTaxProjectionService() {
            return (new RealPropertyTaxProjectionManager());
        }
    }
}
