using Bookies_App.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bookies_App
{
    /// <summary>
    /// Interaction logic for AccountPage.xaml
    /// </summary>
    public partial class AccountPage : Page
    {
        public AccountPage()
        {
            InitializeComponent();

            // get user id from some storage

            //// SET USER ID WHEN ACCOUNT PAGE IS COMPLETE
            string userId = Properties.Settings.Default.loggedIn;
            string userUrl = "/" + userId;

            Task<HttpResponseMessage> accountInfo = WebAPI.GetCall(API_URIs.users + userUrl);
            Debug.WriteLine(accountInfo.Result.Content.ReadAsStringAsync().Result);

            labelEmail.Text = JsonObject.Parse(accountInfo.Result.Content.ReadAsStringAsync().Result)["user"]["email"].ToString();
            labelName.Text = JsonObject.Parse(accountInfo.Result.Content.ReadAsStringAsync().Result)["user"]["name"].ToString();
            labelUsername.Text = JsonObject.Parse(accountInfo.Result.Content.ReadAsStringAsync().Result)["user"]["username"].ToString();
        }
    }
}
