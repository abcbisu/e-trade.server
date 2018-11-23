﻿using etrade.models;
using etrade.services;
using System.Web;
using System;
using etrade;

namespace etrade_server.App_Start
{
    public static class SessionContext
    {
        public static UserMin CurrentUser { get { return GetCurrentUser(); } }

        #region
        static UserMin GetCurrentUser()
        {
            return HttpContext.Current.Items[SiteConstants.SessionKey] as UserMin;
        }
        #endregion
    }
}