using System;
using System.Collections.Generic;
using System.Text;

namespace NewEntity
{
    class Activated : UsabilityLevel
    {
        public override void ActivatePage(BasePage page)
        {
            CheckActivation(page);
        }
        public override void CheckActivation(BasePage page)
        {
            if (pageActivated == true)
            {
                Console.WriteLine("Page is already activated");
            }
            else
            {
                Console.WriteLine("Page is deactivated");

            }
        }

        public override void DeactivatePage(BasePage page)
        {
            pageActivated = false;
            CheckActivation(page);
        }
    }
}
