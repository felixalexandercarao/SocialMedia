using System;
using System.Collections.Generic;
using System.Text;

namespace NewEntity
{
    public abstract class UsabilityLevel
{
    protected BasePage _basePage;
    protected bool _pageActivated;
    public BasePage basePage
    {
        get { return _basePage; }
        set { _basePage = value; }
    }
    public bool pageActivated
        {
            get { return _pageActivated; }
            set {_pageActivated=value; }
        }
    public abstract void ActivatePage(BasePage page);
    public abstract void DeactivatePage(BasePage page);
    public abstract void CheckActivation(BasePage page);
    }
}
