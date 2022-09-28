using DisplayFormApp.DataSourceHandler;
using DisplayFormApp.src.automatePullingData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Microsoft.SharePoint;

namespace DisplayFormApp.src
{
    public partial class AutomatePullingDataForm : Form
    {
        SPAuthenticator sPAuthenticator;
        SPDataRetriever sPDataRetriever;
       
        public AutomatePullingDataForm()
        {
            InitializeComponent();
            modifyUIActions();
            sPAuthenticator = new SPAuthenticator();
            sPDataRetriever = new SPDataRetriever();
        }

        public List<Class> getClasses()
        {
            List<Class> classes = new List<Class>();
            string authToken = sPAuthenticator.authToken;

            if (authToken == null || authToken == "")
            {
                Console.WriteLine("Authtoken is null when getting classes");
                throw new ArgumentNullException("Authtoken is null when getting classes");
            }

            classes.Concat(sPDataRetriever.getLabData(LabName.lab101, authToken));
            classes.Concat(sPDataRetriever.getLabData(LabName.lab176, authToken));
            classes.Concat(sPDataRetriever.getLabData(LabName.lab106, authToken));

            return classes;
        }

        private void onPullDataButtonClicked(Object obj, EventArgs e)

        {
            Console.WriteLine("Attempting to log in");
            
            //first get username and password and pass to the authenticator
            string username = aliasInput.Text;
            string password = passwordInput.Text;
            bool isSuccess = sPAuthenticator.retrieveAuthToken(username, password);

            Console.WriteLine("Login success?", isSuccess);

            //on success close dialog and pass ok message to mainentry form
            if (isSuccess)
            {                
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
             else
            {
                errorText.Text = "Failed to login, try again";
                passwordInput.Clear();
            }


        }

        

        private void AutomatePullingDataForm_Load(object sender, EventArgs e)
        {

        }
    }
}
