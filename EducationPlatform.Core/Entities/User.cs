using EducationPlatform.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.Core.Entities;
public sealed class User : BaseEntity
{
    public User(string name, string surname, string email, string password, string document, DateTime birthDate, string phone, RoleEnum role)
    {
        Name = name;
        Surname = surname;
        Email = email;
        Password = password;
        Document = document;
        BirthDate = birthDate;
        Phone = phone;
        Role = role;
    }

    public string Name { get; private set; }
    public string Surname { get; private set; }
    public string Email { get; private set; }
    public string Password { get; private set; }
    public string Document { get; private set; }
    public DateTime BirthDate { get; private set; }
    public string Phone { get; private set; }
    public RoleEnum Role { get; private set; }

    public void UpdateData(string name, string surname, string document, string phone)
    {
        Name = name;
        Surname = surname;
        Document = document;
        Phone = phone;
    }
}
