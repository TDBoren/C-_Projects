﻿using Microsoft.Ajax.Utilities;
using NewsletterAppMVC.Models;
using NewsletterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsletterAppMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly string connectionString = @"Data Source=DESKTOP-Q2R5JGD\SQLEXPRESS;
                Initial Catalog=Newsletter;Integrated Security=True;Connect Timeout=30;
                Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                MultiSubnetFailover=False";
        
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(string firstName, string lastName, string emailAddress)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                //using (NewsletterEntities db = new NewsletterEntities())
                //{
                //    var signup = new SignUpVm();
                //    signup.FirstName = firstName;
                //    signup.LastName = lastName;
                //    signup.EmailAddress = emailAddress;

                //    db.SignUps.Add(signup);
                //    db.SaveChanges();
                //}
                string queryString = @"INSERT INTO SignUps (FirstName, LastName, EmailAddress) VAlUES
                                        (@FirstName, @LastName, @EmailAddress)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.Add("@FirstName", SqlDbType.VarChar);
                    command.Parameters.Add("@LastName", SqlDbType.VarChar);
                    command.Parameters.Add("@EmailAddress", SqlDbType.VarChar);

                    command.Parameters["@FirstName"].Value = firstName;
                    command.Parameters["@LastName"].Value = lastName;
                    command.Parameters["@EmailAddress"].Value = emailAddress;

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                    return View("Success");
            }
        }

        public ActionResult Admin()
        {
            //using (NewsletterEntities db = new NewsletterEntities())
            //{
            //    var signups = db.SignUps;
            //    var signUpVms = new List<SignUpVm>();
            //    foreach (var signup in signups)
            //    {
            //        var signUpVm = new SignUpVm();
            //        signUpVm.FirstName = signup.FirstName;
            //        signUpVm.LastName = signup.LastName;
            //        signUpVm.EmailAddress = signup.EmailAddress;
                    
            //        signUpVms.Add(signUpVm);
            //    }
                //return View(signUpVms);
            //}
            string queryString = @"SELECT Id, FirstName, LastName, EmailAddress, SocialSecurityNumber from SignUps";
            List<NewsletterSignUp> signups = new List<NewsletterSignUp>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var signup = new NewsletterSignUp();
                    signup.FirstName = reader["FirstName"].ToString();
                    signup.LastName = reader["LastName"].ToString();
                    signup.EmailAddress = reader["EmailAddress"].ToString();
                    signup.SocialSecurityNumber = reader["SocialSecurityNumber"].ToString();

                    signups.Add(signup);
                }
            }
            var signUpVms = new List<SignUpVm>();
            foreach (var signup in signups)
            {
                var signUpVm = new SignUpVm();
                signUpVm.FirstName = signup.FirstName;
                signUpVm.LastName = signup.LastName;
                signUpVm.EmailAddress = signup.EmailAddress;
                signUpVms.Add(signUpVm);
            }
            return View(signUpVms);
        }
    }
}