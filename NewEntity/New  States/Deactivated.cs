using System;
using System.Collections.Generic;
using System.Text;

namespace NewEntity
{
    class Deactivated : UsabilityLevel
    {
        public override void ActivatePage(BasePage page)
        {
            pageActivated = false;
            CheckActivation(page);
        }
        public override void CheckActivation(BasePage page)
        {
            if (pageActivated == true)
            {
                Console.WriteLine("Page is activated");
            }
            else
            {
                Console.WriteLine("Page is already deactivated");

            }
        }

        public override void DeactivatePage(BasePage page)
        {
            CheckActivation(page);
        }
    }
}
