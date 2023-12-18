using Bookies_App.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
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
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();

            /// get user login info

            User loggedIn = new User();

            //// TESTING INFORMATION
            /*loggedIn.username = "app_tester";
            loggedIn.password = "test12";*/

            //// UNCOMMENT WHEN REGISTRATION IS IS DONE

            /*Task<HttpResponseMessage> login = WebAPI.PostCall(API_URIs.users + API_URIs.login, loggedIn);
            //Debug.WriteLine(login.Result.Content.ReadAsStringAsync().Result);
            if (login.Result.StatusCode != System.Net.HttpStatusCode.OK)
            {
                // give user heads up that something failed
            } else
            {
                // else if login was successful give user their ID
                loggedIn.id = JsonObject.Parse(login.Result.Content.ReadAsStringAsync().Result)["user"]["id"].ToString();
                //Debug.WriteLine(loggedIn.id);
            }*/



        }
    }
}
