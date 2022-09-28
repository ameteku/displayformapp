using Microsoft.SharePoint.Client;
using System;
using System.Security;
//using Microsoft.SharePointOnl
namespace DisplayFormApp.src.automatePullingData
{
    internal class SPAuthenticator
    {
        private string siteCollectionUrl = "https://uazips.sharepoint.com";
       public bool isAuthenticated {get;}
        private string username;
        private string password;
        private string authToken { get; }

        SPAuthenticator(string password, string username)
        {
            this.password = password;
            this.username = username;
            isAuthenticated = false;
        }

        void retrieveAuthToken()
        {
           ClientContext ctx = new ClientContext(siteCollectionUrl);

            SecureString secureString = new SecureString();
            password.ToList().ForEach(secureString.AppendChar);

          ctx.Credentials = new SharePoint(username, secureString);
        }
        
    }
}
