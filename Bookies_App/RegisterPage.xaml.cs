using Bookies_App.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
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
    /// Interaction logic for RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : Page
    {
        public RegisterPage()
        {
            InitializeComponent();

            txtBox_name.Text = string.Empty;
            txtBox_username.Text = string.Empty;
            txtBox_email.Text = string.Empty;
            txtBox_password.Password = string.Empty;

            ///somehow get the registration information and click button for function call

            //// TESTING INFORMATION
            /*newUser.username = "app_tester";
            newUser.name = "app";
            newUser.email = "testing@app.com";
            newUser.password = "test12";*/

            //// UNCOMMENT WHEN REGISTRATION IS IS DONE
            /*Task<HttpResponseMessage> insert = WebAPI.PostCall(API_URIs.users + API_URIs.signup, newUser);

            //// MORE TESTING LINES
            //Debug.WriteLine(insert.Result.Content.ReadAsStringAsync().Result);
            if (insert.Result.StatusCode != System.Net.HttpStatusCode.Created)
            {
                // give user heads up that something failed
            }*/
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User newUser = new User();
            ///
            newUser.name = txtBox_name.Text;
            newUser.email = txtBox_email.Text;
            newUser.username = txtBox_username.Text;
            newUser.password = txtBox_password.Password;


            Task<HttpResponseMessage> insert = WebAPI.PostCall(API_URIs.users + API_URIs.signup, newUser);

            Debug.WriteLine(insert.Result.Content.ReadAsStringAsync().Result);
            if (insert.Result.StatusCode != System.Net.HttpStatusCode.Created)
            {
                label_error.Content = "Napaka pri ustvarjanju uporabnika";
            }
            else
            {
                label_error.Content = "Uporabnik uspešno kreiran";
            }
        }
    }
}
