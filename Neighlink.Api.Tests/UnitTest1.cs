using Microsoft.VisualStudio.TestTools.UnitTesting;
using Neighlink.Repository;
using Neighlink.Entity;
using Neighlink.Repository.implementation;
using Neighlink.Repository.Context;
using TechTalk.SpecFlow.CommonModels;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using Microsoft.Extensions.Options;

namespace Neighlink.Api.Tests
{
   
    [TestClass]
    public class UnitTest1
    {
        ApplicationDbContext context;
        IOptions<PrivateSettings> settings;

        [TestMethod]
        public void HU07()
        {
            User usuario = new User();
            UserRepository rep = new UserRepository(context, settings);
            usuario = rep.Authenticate("correo@gmail.com", "21312");
            Assert.AreEqual(rep.Authenticate("correo@gmail.com", "21312"),usuario);
        }

        [TestMethod]
        public void HU08()
        {
            Payment pago = new Payment();

            PaymentRepository rep = new PaymentRepository(context);
            pago.BillId = 1;
            IEnumerable<Payment> expected;
            expected = rep.GetPaymentsByBill(pago.BillId);

            Assert.AreEqual(rep.GetPaymentsByBill(1), expected);

        }
    }
}
