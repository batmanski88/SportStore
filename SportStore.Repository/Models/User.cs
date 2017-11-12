using System;
using System.Collections.Generic;
using System.Text;

namespace SportStore.Repository.Models
{
    public class User
    {
        public Guid UserId { get; protected set; }
        public string UserName { get; protected set; }
        public string Password { get; protected set; }
        public string Salt { get; protected set; }
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public string Address { get; protected set; }
        public string City { get; protected set; }
        public string Code { get; protected set; }
        public string Email { get; protected set; }
        public DateTime CreatedAt { get; protected set; }
        public DateTime UpdatedAt { get; protected set; }

        public User(Guid userId, string userName, string password, string salt, string email)
        {
            UserId = userId;
            SetUserName(userName);
            SetPassword(password, salt);
            SetEmail(email);
            CreatedAt = DateTime.UtcNow;
        }

        public void SetUserName(string userName)
        {
            if(UserName == userName)
            {
                return;
            }
            UserName = userName;
        }

        public void SetPassword(string password, string salt)
        {
            Password = password;
            Salt = salt;
            UpdatedAt = DateTime.UtcNow;
        }

        public void SetFirstName(string firstName)
        {
            if(FirstName == firstName)
            {
                return;
            }
            FirstName = firstName;
        }

        public void SetLastName(string lastName)
        {
            if(LastName == lastName)
            {
                return;
            }
            LastName = lastName;
        }

        public void SetAddress(string address)
        {
            if(Address == address)
            {
                return;
            }
            Address = address;
        }

        public void SetCity(string city)
        {
            if(City == city)
            {
                return;
            }
            City = city;
        }

        public void SetCode(string code)
        {
            if(Code == code)
            {
                return;
            }
            Code = code;
        }

        public void SetEmail(string email)
        {
            if(Email == email)
            {
                return;
            }
            Email = email;
        }
    }
}
