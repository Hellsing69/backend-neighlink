using Microsoft.VisualStudio.TestTools.UnitTesting;
using Neighlink.Repository;
using Neighlink.Entity;
using Neighlink.Service;
using Neighlink.Repository.implementation;
using Neighlink.Repository.Context;
using Neighlink.Api;
using TechTalk.SpecFlow.CommonModels;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using Microsoft.Extensions.Options;
using Neighlink.Api.Controllers;

namespace Neighlink.Api.Tests
{
   
    [TestClass]
    public class UnitTest1
    {
        private Payment pago = new Payment();
        private User usuario = new User();
        ApplicationDbContext context;
        IOptions<PrivateSettings> settings;


        [TestMethod]
        public void HU07()
        {
            
            UserRepository rep = new UserRepository(context, settings);
            usuario = rep.Authenticate("correo@gmail.com", "21312");
            Assert.AreEqual(rep.Authenticate("correo@gmail.com", "21312"),usuario);
        }

        [TestMethod]
        public void HU08()
        {

            PaymentRepository rep = new PaymentRepository(context);
            pago.BillId = 1;
            IEnumerable<Payment> expected;
            expected = rep.GetPaymentsByBill(pago.BillId);

            Assert.AreEqual(rep.GetPaymentsByBill(1), expected);

        }

        [TestMethod]
        public void HU01()
        {
            User user;
            UserRepository rep = new UserRepository(context, settings);
            user = rep.Authenticate("correo@gmail.com", "21312");
            Assert.AreEqual(rep.Authenticate("correo@gmail.com", "21312"), user);

        }

        [TestMethod]
        public void HU06()
        {
            Condominium cond = new Condominium();
            usuario.Id = 1;
            CondominiumRepository rep = new CondominiumRepository(context);
            Assert.AreEqual(rep.Get(usuario.Id), cond);

        }
    }
}
