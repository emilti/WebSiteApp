using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MySite
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string accountName = name.Text;
            string accountWebsiteurl = website.Text;

            BasicHttpBinding myBinding = new BasicHttpBinding();
            myBinding.Name = "ServiceCalledFromWebSite.AccountWebServiceClient ";
            myBinding.Security.Mode = BasicHttpSecurityMode.None;
            myBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.None;
            myBinding.Security.Transport.ProxyCredentialType = HttpProxyCredentialType.None;
            myBinding.Security.Message.ClientCredentialType = BasicHttpMessageCredentialType.UserName;
            EndpointAddress endPointAddress = new EndpointAddress("http://vsisso23/ServiceCalledFromWebSite/AccountWebService.svc?wsdl");
            ServiceCalledFromWebSite.AccountWebServiceClient myClient = new ServiceCalledFromWebSite.AccountWebServiceClient(myBinding, endPointAddress);
            HashSet<string> serviceFields = new HashSet<string> { "modifiedon", "modifiedby", "modifiedonbehalfby", "accountid" };

            int accountEntityNumber = int.Parse(entityNumber.Text);
            myClient.CreateAccount(accountEntityNumber, accountName, accountWebsiteurl);
        }
    }
}