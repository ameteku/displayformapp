using System.Text;

namespace DisplayFormApp.src.automatePullingData
{
    public enum LabName { lab101, lab176, lab106 }

     public class SPDataRetriever
    {
        HttpClient client;
        private bool hasAddedDefaultHeaders = false;
        static private Uri baseAddress = new Uri("https://uazips.sharepoint.com");
        static private string mainApiEndpoint = "sites/cba/lists/_api/Web/lists";
        static private string selectQuery = "$select=";
        static private String filterQuery = "$filter=";

        static private Dictionary<LabName, string> labUrlNames = new Dictionary<LabName, string>()
        {
            [LabName.lab101] = "CBA 106",
            [LabName.lab176] = "CBA 176",
            [LabName.lab101] = "CBA 101"
        };

        static private List<string> queryProperties = new List<string>()
        { "Title","Created", "Location", "EventDate", "EndDate", "fRecurrence", "RecurrenceData" };

        static private List<string> filterProperties = new List<string>(){ };

        public SPDataRetriever()
        {
            client = new HttpClient()
            {
                BaseAddress = baseAddress
            };

        }

        //this is ued to get the lab data from sharepoint
        public List<Class>  getLabData(LabName lab, string authenticationToken)
        {

            if(authenticationToken == null || authenticationToken.Length == 0 )
            {
                throw new NotAuthenticatedException(
                    "Application has not been authenticated, wait for a few minutes, try logging in again or reach out developer");
            }

            //add headers needed once
            if (!hasAddedDefaultHeaders)
            {
                client.DefaultRequestHeaders.Add("authToken", authenticationToken);
            }

            string fullEndpoint = buildSPQuery(labUrlNames[lab]);
            String responseData;
            try
            {
                 responseData = callUrl(fullEndpoint).Result;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("calling url: " + fullEndpoint + " was not successful ", e);
            }

            //convert response data to json/ directly to the csv data we need
            List<Class> labData = new List<Class>();

            return labData;
        }

        //builds the query string needed using the labname
        string buildSPQuery(String labName)
        {
            Console.WriteLine("Starting to build query");

            if(labName == null || labName.Length == 0) {
                throw new ArgumentException("labName: " + labName + " is not valid");
            }
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(mainApiEndpoint).Append("GetByTitle(\'").Append(labName).Append("\')/items?").Append(selectQuery);

            //appending select properties 
            for(int i = 0; i < queryProperties.Count; i++)
            {
                stringBuilder.Append(queryProperties[i]);
                if(i != queryProperties.Count - 1)
                {
                    stringBuilder.Append(',');
                }
            }

            stringBuilder.Append("&" + filterQuery);

            //appending filter properties
            for (int i = 0; i < filterProperties.Count; i++)
            {
                stringBuilder.Append(filterProperties[i] + ",");
                if (i != queryProperties.Count - 1)
                {
                    stringBuilder.Append(',');
                }
            }

            return stringBuilder.ToString();   
        }

        //calls the query passed in together with the baseaddress above
        private async Task<string> callUrl(string query)
        {
            HttpResponseMessage response = client.GetAsync(query).GetAwaiter().GetResult();

            bool isSuccess = response.IsSuccessStatusCode;
            if (isSuccess)
            {
                String body = await response.Content.ReadAsStringAsync();

                return body;

            }
            else
            {
                throw new HttpRequestException("An error with status:" + response.StatusCode + " occured whilst calling url: ");
            }
        }
    }

}
