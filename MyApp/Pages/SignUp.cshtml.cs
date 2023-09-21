using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace MyApp.Pages
{
    public class SignUpModel : PageModel

    {
        public string errorMessage = "";
       public UserInfo userinfo = new();
        public void OnGet()
        {
        }
        public void OnPost()
        {
            try
            {
                string  connectionString = "Data Source=localhost\\SQLEXPRESS;Integrated Security=True ";
                SqlConnection sqlConnection = new(connectionString);
                Connection open();
            }
            catch (Exception ex) 
            {
                errorMessage = ex.Message;
Console.WriteLine(ex.ToString());
            }
        }

    }
}
