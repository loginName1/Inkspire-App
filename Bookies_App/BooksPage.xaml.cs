using Bookies_App.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
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
    /// Interaction logic for BooksPage.xaml
    /// </summary>
    public partial class BooksPage : Page
    {
        public BooksPage()
        {
            //// KOMENTARJI ZA RAZLAGO PRIMERA UPORABE API KLICEV
            
            InitializeComponent();
            //// API KLIC SE NAREDI Z UPORABO "WebAPI" FUNKCIJ
            //// V OKLEPAJ SE DA SAMO ZADNJI DEL API KLICA (PRIMER JE V MAPI "Utilities" OD KOD SO VZETI "API_URIs")
            //// KLICI VRNEJO OBJEKT TIPA "Task" (KER C# TAKO UREJA VSE KLICE) V TEM PRIMERU JE IZBRANA BILA SPREMENLJIVKA TIPA "var" AMPAK,
            //// BI LAHKO UPORABILI TUDI "Task<HttpResponseMessage>"
            var bookResponse = WebAPI.GetCall(API_URIs.books);
            //// ČE KAJ NI JASNO SE LAHKO DEBUGIRA S TEMI KLICI:
            //Debug.WriteLine(bookResponse.Result.StatusCode); // VRNE STATUS KODO KLICA (PRIMER GET: "Ok")
            //Debug.WriteLine(bookResponse.Result.Content.ReadAsStringAsync().Result);
            //// PRETVORBA IZ TASKA V DEJANSKI PARSABLE JSON JE ZAHTEVNA IN ČE SI LEN TI NI POTREBNO PREMIŠLJEVATI OD KOD PA ZAKAJ JE TAKO
            //// UPORABI SE "JsonSerializer.Deserialize<Class>(json variable)"
            //// "bookResponse.Result.Content.ReadAsStringAsync().Result" JE V NAŠEM PRIMERU NAČIN PRIDOBITVE JSONA (REZULTAT NI DEJANSKI JSON OBJEKT AMPAK STRING JSONA)
            //// (PAMETNO SHRANITI V SPREMENLJIVKO ČE SE NA STRANI VEČKRAT DELA S PODATKI)
            string jsonedBooks = bookResponse.Result.Content.ReadAsStringAsync().Result;
            //// ZA DESERIALIZACIJO SEZNAMA PODATKOV (TOREJ VEČ KNJIG TU) SE NAREDI CLASS KJER SE NAHAJA SEZNAM BASE OBJEKTOV (PRIPORČLJIVO JE VKLJUČITI TUDI COUNT SPREMENLJIVKO)
            BookList listBooks = JsonSerializer.Deserialize<BookList>(jsonedBooks);
            //// MORE DEBUGGING LINES
            //listBooks.books.ForEach(p => Debug.WriteLine(p.name));
            //// NE POZABITI REFERENCIRATI DEJANSKIH OBJEKTOV V SEZNAMU
            BookList.ItemsSource = listBooks.books;
        }


    }


}
