using System;

namespace CodeBlogFitness.BL.Model
{
    /// <summary>
    /// User.
    /// </summary>
    [Serializable]
    public class User
    {
        #region Properties
        /// <summary>
        /// Name.
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Gender.
        /// </summary>
        public Gender Gender { get; } 
        /// <summary>
        /// BirthDate.
        /// </summary>
        public DateTime BirthDate { get; }
        /// <summary>
        /// Weight.
        /// </summary>
        public double Weight { get; set; }
        /// <summary>
        /// Height.
        /// </summary>
        public double Height { get; set; }
        #endregion

        /// <summary>
        /// Create new user.
        /// </summary>
        /// <param name="name"> Name. </param>
        /// <param name="gender"> Gender. </param>
        /// <param name="birthDate"> BirthDate. </param>
        /// <param name="weight"> Weight. </param>
        /// <param name="height"> Height. </param>
        public User(string name,
                    Gender gender,
                    DateTime birthDate,
                    double weight,
                    double height)
        {
            #region Condition check
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("User name can't be empty or null.", nameof(name));
            }

            if (gender == null)
            {
                throw new ArgumentNullException("User gender can't be empty or null.", nameof(gender));
            }

            if (birthDate < DateTime.Parse("01.01.1900") || birthDate >= DateTime.Now)
            {
                throw new ArgumentException("Invalid birth date.", nameof (birthDate));
            }

            if (weight <= 0)
            {
                throw new ArgumentException("Weight can't be less than or equal to 0.", nameof(weight));
            }
            
            if (height <= 0)
            {
                throw new ArgumentException("Height can't be less than or equal to 0.", nameof(height));
            }
            #endregion

            Name = name;
            Gender = gender;
            BirthDate = birthDate;
            Weight = weight;
            Height = height;
        }

        public override string ToString()
        {
            return Name; 
        }
    }
}
