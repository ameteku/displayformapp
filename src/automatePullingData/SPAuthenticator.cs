﻿using Microsoft.SharePoint.Client;
using System;
using System.Security;
//using Microsoft.SharePointOnl
namespace DisplayFormApp.src.automatePullingData
{
    public  class SPAuthenticator
    {
        private string siteCollectionUrl = "https://uazips.sharepoint.com";
         private bool isAuthenticated { get; set; }
        public string authToken { get; }
        static private string clientSecret ="xxxxx"; //todo
        static private string clientId = "xxxxx"; //todo

        public SPAuthenticator()
        {
            isAuthenticated = false;
        }

       public bool IsAuthenticated()
        {
            return isAuthenticated;
        }

        public bool retrieveAuthToken(string password, string username)
        {
            bool isSuccess = false;
            ClientContext ctx = new ClientContext(siteCollectionUrl);

            SecureString secureString = new SecureString();
            password.ToList().ForEach(secureString.AppendChar);
            ctx.Credentials = new SharePo(username, secureString);

            isAuthenticated = isSuccess;
            
            return isSuccess;
        }
        
    }
}
