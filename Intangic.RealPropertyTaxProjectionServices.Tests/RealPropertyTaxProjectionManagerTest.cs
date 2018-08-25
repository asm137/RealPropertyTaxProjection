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
    public class RealPropertyTaxProjectionManagerTest
    {
        IRealPropertyTaxProjectionService realPropertyTaxProjectionManager;
        Result result;

        [TestInitialize]
        public void Initialize() {
            realPropertyTaxProjectionManager = new RealPropertyTaxProjectionManager();
            result = new Result();
        }

        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod, Ignore]
        public void Login_LoginSystemAdmin_Success_Test()
        {
            LoginRequest request = null;
            LoginResponse response = null;

            request = new LoginRequest() {
                 UserName = "sysad", Password = null
            };

            try {
                response = new LoginResponse();
                response = realPropertyTaxProjectionManager.Login(request);
                result.Code = RPTP.Enumerations.ResultResponse.Success;
                result.Description = string.Empty;

                Console.WriteLine("user name: {0}\t\t\tpassword: {1}\n",
                    request.UserName, request.Password);
                Console.WriteLine("is login valid: {0}\n" + "is admin: {1}\n" + "access level: {2}\n", 
                    response.IsLoginValid, response.IsAdmin , response.AccessLevel);
            }
            catch (RealPropertyTaxProjectionException ex) {
                result.Code = RPTP.Enumerations.ResultResponse.Failed;
                result.Description = ex.Message;
            }
            catch (Exception ex) {
                result.Code = RPTP.Enumerations.ResultResponse.SystemError;
                result.Description = string.Format("{0}{1}", result.Code.ToString(), ex.Message);
            }
            response.Result = result;

            Assert.AreEqual(RPTP.Enumerations.ResultResponse.Success, response.Result.Code, response.Result.Description);

            //dispose objects
            response = null;
            request = null;
        }

        [TestMethod]
        public void ExportBuildingDataAssessorFile_Success_Test()
        {
            realPropertyTaxProjectionManager.ExportBuildingDataAssessorFile(null);
        }
    }
}
