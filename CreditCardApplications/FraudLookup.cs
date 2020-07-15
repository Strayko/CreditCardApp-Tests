using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCardApplications
{
    public class FraudLookup
    {
        public bool IsFraudRisik(CreditCardApplication application)
        {
            return CheckApplication(application);
        }

        protected virtual bool CheckApplication(CreditCardApplication application)
        {
            if (application.FirstName == "Moamer")
            {
                return true;
            }

            return false;
        }
    }
}
