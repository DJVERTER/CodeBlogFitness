using CodeBlogFitness.BL.Model;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CodeBlogFitness.BL.Controller
{
    /// <summary>
    /// User Controller
    /// </summary>
    public class UserController
    {
        /// <summary>
        /// Aplication user.
        /// </summary>
        public User User { get; }

        /// <summary>
        /// Creati new user controller.
        /// </summary>
        /// <param name="user"></param>
        public UserController(string userName, string genderName, DateTime birdthDay, double weight, double height )
        {
            //TODO

            var gender = new Gender(genderName);
            User = new User(userName, gender, birdthDay, weight, height);
        }

        public UserController()
        {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                if (formatter.Deserialize(fs) is User user)
                {
                    User = user;
                }

                //TODO: What do, if user not readed?
            }
        }

        /// <summary>
        /// Save user data.
        /// </summary>
        public void Save()
        {
            var formatter = new BinaryFormatter();

            using(var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, User);
            }
        }

        /// <summary>
        /// Get user data.
        /// </summary>
        /// <returns> Aplication user. </returns>
        
    }
}
