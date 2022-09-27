using Microsoft.SharePoint.Client;
using System;
using System.Security;
using Microsoft.SharePointOnl
namespace DisplayFormApp.src.automatePullingData
{
    internal class SPAuthenticator
    {
        private string siteCollectionUrl = "https://uazips.sharepoint.com";
        private string username;
        private string password;
        private string authToken;

        SPAuthenticator(string password, string username)
        {
            this.password = password;
            this.username = username;
        }

        void retrieveAuthToken()
        {
            ClientContext ctx = new ClientContext(siteCollectionUrl);

            SecureString secureString = new SecureString();
            password.ToList().ForEach(secureString.AppendChar);

            ctx.Credentials = new SharePointOnline(username, secureString);
        }
        
    }
}
