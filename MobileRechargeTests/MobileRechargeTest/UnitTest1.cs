using System;
using Xunit;
using MobileRechargeApp;
using System.Collections.Generic;

namespace MobileRechargeTest
{
    public class UnitTest1
    {
        [Fact]
        public void AddNewPlanTest()
        {
            RechargePlansMenu rechargePlansMenu = new RechargePlansMenu();
            UnlimitedMessagesForMonth unlimitedMessagesForMonth = new UnlimitedMessagesForMonth();
            UnlimitedCallsForMonth unlimitedCallsForMonth = new UnlimitedCallsForMonth();
            rechargePlansMenu.AddPlan(unlimitedCallsForMonth);
            rechargePlansMenu.AddPlan(unlimitedMessagesForMonth);
            List<RechargePlan> allPlans = new List<RechargePlan>();
            allPlans.Add(unlimitedCallsForMonth);
            allPlans.Add(unlimitedMessagesForMonth);
            Assert.Equal(allPlans, rechargePlansMenu.GetRechargePlansMenu());
        }
        [Fact]
        public void SelectPlanTest()
        {
            RechargePlansMenu rechargePlansMenu = new RechargePlansMenu();
            UnlimitedMessagesForMonth unlimitedMessagesForMonth = new UnlimitedMessagesForMonth();
            UnlimitedCallsForMonth unlimitedCallsForMonth = new UnlimitedCallsForMonth();
            rechargePlansMenu.AddPlan(unlimitedCallsForMonth);
            rechargePlansMenu.AddPlan(unlimitedMessagesForMonth);
            RechargeSelector rechargeSelector = new RechargeSelector(rechargePlansMenu);
            rechargeSelector.ValidateRecharge(unlimitedCallsForMonth);
            PaymentFactory paymentFactory = new PaymentFactory(rechargeSelector.GetRechargePlan(), "UPI");
            var paymentMode=paymentFactory.PaymentSource();
            string output=paymentMode.MakePayment();
            Assert.Equal(output, "Mobile Recharge of UnlimitedCallsForMonth of amount 199 is succesfull through UPI");
        }
        [Fact]
        public void CardPaymentTest()
        {

            RechargePlansMenu rechargePlansMenu = new RechargePlansMenu();
            UnlimitedMessagesForMonth unlimitedMessagesForMonth = new UnlimitedMessagesForMonth();
            UnlimitedCallsForMonth unlimitedCallsForMonth = new UnlimitedCallsForMonth();
            rechargePlansMenu.AddPlan(unlimitedCallsForMonth);
            rechargePlansMenu.AddPlan(unlimitedMessagesForMonth);
            RechargeSelector rechargeSelector = new RechargeSelector(rechargePlansMenu);
            rechargeSelector.ValidateRecharge(unlimitedMessagesForMonth);
            PaymentFactory paymentFactory = new PaymentFactory(rechargeSelector.GetRechargePlan(), "Card");
            var paymentMode = paymentFactory.PaymentSource();
            string output = paymentMode.MakePayment();
            Assert.Equal(output, "Mobile Recharge of UnlimitedMessagesForMonth of amount 50 is succesfull through Card");
        }
    }
}
