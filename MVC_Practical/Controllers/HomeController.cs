using MVC_Practical.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web.Mvc;

namespace MVC_Practical.Controllers
{
    public class HomeController : Controller
    {
        string connectionString = @"Data Source = (localdb)\ProjectsV13; Initial Catalog = MVC_Final; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
       

        public ActionResult Index()
        {
            return View();
        }



        [HttpPost]
        public ActionResult InsuranceQuote(string firstName, string lastName, string emailAddress, string dateOfBirth,
            string carYear, string carMake, string carModel, string Dui, string speedingTickets, string coverage)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress) || string.IsNullOrEmpty(dateOfBirth) ||
                string.IsNullOrEmpty(carYear) || string.IsNullOrEmpty(carMake) || string.IsNullOrEmpty(carModel) || string.IsNullOrEmpty(Dui) || string.IsNullOrEmpty(speedingTickets) || string.IsNullOrEmpty(coverage))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {

                string queryString = @"INSERT INTO InsuranceQuote (FirstName, LastName, EmailAddress, NewQuote, DateOfBirth, CarYear, CarMake, CarModel, DUI, SpeedingTickets, Coverage) VALUES
                        (@FirstName, @LastName, @EmailAddress, @NewQuote, @DateOfBirth, @CarYear, @CarMake, @CarModel, @DUI, @SpeedingTickets, @Coverage)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.Add("@FirstName", SqlDbType.VarChar);
                    command.Parameters.Add("@LastName", SqlDbType.VarChar);
                    command.Parameters.Add("@EmailAddress", SqlDbType.VarChar);
                    command.Parameters.Add("@NewQuote", SqlDbType.Int);
                    command.Parameters.Add("@DateOfBirth", SqlDbType.DateTime);
                    command.Parameters.Add("@CarYear", SqlDbType.Int);
                    command.Parameters.Add("@CarMake", SqlDbType.VarChar);
                    command.Parameters.Add("@CarModel", SqlDbType.VarChar);
                    command.Parameters.Add("@DUI", SqlDbType.VarChar);
                    command.Parameters.Add("@SpeedingTickets", SqlDbType.Int);
                    command.Parameters.Add("@Coverage", SqlDbType.VarChar);
                    

                    command.Parameters["@FirstName"].Value = firstName;
                    command.Parameters["@LastName"].Value = lastName;
                    command.Parameters["@EmailAddress"].Value = emailAddress;
                    command.Parameters["@NewQuote"].Value = newQuote;
                    command.Parameters["@DateOfBirth"].Value = dateOfBirth;
                    command.Parameters["@CarYear"].Value = carYear;
                    command.Parameters["@CarMake"].Value = carMake;
                    command.Parameters["@CarModel"].Value = carModel;
                    command.Parameters["@DUI"].Value = Dui;
                    command.Parameters["@SpeedingTickets"].Value = speedingTickets;
                    command.Parameters["@Coverage"].Value = coverage;
                    

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                return View("Success");
            }
        }

        public ActionResult Admin()
        {
            string queryString = @"SELECT Id, FirstName, LastName, EmailAddress, NewQuote, DateOfBirth, CarYear, CarMake, CarModel,
                    DUI, SpeedingTickets, Coverage from InsuranceQuote";
            List<NewInsuranceQuote> quotes = new List<NewInsuranceQuote>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var quote = new NewInsuranceQuote();
                    quote.Id = Convert.ToInt32(reader["Id"]);
                    quote.FirstName = reader["FirstName"].ToString();
                    quote.LastName = reader["LastName"].ToString();
                    quote.EmailAddress = reader["EmailAddress"].ToString();
                    quotes.Add(quote);
                }
            }
            return View(quotes);
        }
        public DateTime DateOfBirth { get; private set; }
        public int newQuote { get; private set; }
        public int carYear { get; private set; }
        public string carMake { get; private set; }
        public string carModel { get; private set; }
        public int speedingTickets { get; private set; }
        public string Dui { get; private set; }
        public string coverage { get; private set; }
        public DateTime dateOfBirth { get; private set; }



        public new ActionResult User
        {
            get
            {

                {
                    string queryString = @"SELECT NewQuote from InsuranceQuote";
                    List<NewInsuranceQuote> quotes = new List<NewInsuranceQuote>();

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand(queryString, connection);

                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();



                        while (reader.Read())
                        {
                            var quote = new NewInsuranceQuote();
                            //quote.Id = Convert.ToInt32(reader["Id"]);
                            // quote.NewQuote = Convert.ToInt32(reader["NewQuote"]);
                            new List<NewInsuranceQuote>().Add(quote);

                            newQuote = 50;
                            var Now = DateTime.Today;
                            var UserAge = Now.Year - dateOfBirth.Year;
                            if (dateOfBirth > Now.AddYears(-25))
                            {
                                newQuote = newQuote + 25;
                            }
                            else if (dateOfBirth > Now.AddYears(-18))
                            {
                                newQuote = newQuote + 100;
                            }
                            else if (dateOfBirth > Now.AddYears(-100))
                            {
                                newQuote = newQuote + 25;
                            }
                            if (carYear < 2000)
                            {
                                newQuote = newQuote + 25;
                            }
                            else if (carYear > 2015)
                            {
                                newQuote = newQuote + 25;
                            }
                            if (carMake == "Porche")
                            {
                                newQuote = newQuote + 25;
                            }
                            if (carMake == "Porche" && carModel == "911 Carrera")
                            {
                                newQuote = newQuote + 25;
                            }
                            if (speedingTickets > 0)
                            {
                                newQuote = newQuote + 10 * speedingTickets;
                            }
                            if (Dui == "yes")
                            {
                                newQuote = newQuote * (25 / 100);
                            }
                            else
                            {
                                newQuote = newQuote + 0;
                            }
                            if (coverage == "Full Coverage || full coverage || full")
                            {
                                newQuote = newQuote * (50 / 100);
                            }
                            else
                            {
                                newQuote = newQuote + 0;
                            }
                        }
                        return View(newQuote);
                    }
                }
            }
        }
    }    
}