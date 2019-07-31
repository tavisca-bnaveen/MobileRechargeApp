using System.Collections.Generic;

namespace MobileRechargeApp
{
    public abstract class AbstractRechargePlansMenu
        {
        public abstract void AddPlan(RechargePlan rechargePlan);
        public abstract List<RechargePlan> GetRechargePlansMenu();

        }


}
