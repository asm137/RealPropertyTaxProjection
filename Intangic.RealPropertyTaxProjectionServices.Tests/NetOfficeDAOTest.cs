using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Intangic.RPTP.Domain;
using Intangic.RPTP.Business.Exceptions;
using Intangic.RPTP.Business.Impl;
using Intangic.RPTP.Business.Interfaces;
using Intangic.RPTP.Factory;

namespace Intangic.RealPropertyTaxProjectionServices.Tests
{
    [TestClass]
    public class NetOfficeDAOTest
    {
        IRealPropertyTaxProjectionService realPropertyTaxProjectionManager;
        Result result;

        [TestInitialize]
        public void Initialize()
        {
            realPropertyTaxProjectionManager = new RealPropertyTaxProjectionManager();
            result = new Result();
        }

        [TestMethod]
        public void TestMethod1()
        {
        }


    }
}
