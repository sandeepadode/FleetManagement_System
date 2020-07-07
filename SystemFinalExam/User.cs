using System;
using System.Collections.Generic;
using System.Text;

namespace SystemFinalExam
{
    /// <summary>
    /// A 'User' Class
    /// This class is used to register and login the customers to the Fly India airline system
    /// </summary>
    public class User
    {
        private string emailId;
        private string password;
        public string EmailId
        {
            get => emailId;
            set => emailId = value;
        }
        public string Password
        {
            get => password;
            set => password = value;
        }

        public User()
        {
            this.EmailId = "";
            this.Password = "";
        }
        /// <summary>
        /// The Register function lets the un-registered customers to register with the Fly India System.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        public void Register(string email, string password)
        {
            Console.WriteLine($"Thanks {email} for registering with us!");
        }
        /// <summary>
        /// The Login function lets the registered customers to login to the Fly India System.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        public void Login(string email, string password)
        {
            if (email=="dalibor" && password=="dvorski")
            {
                Console.WriteLine($"Welcome back {email}");
            }
            else
            {
                Console.WriteLine("Incorrect email or password!");
            }
            
        }

    }
}
