using EducationPlatform.Core.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.Application.Models.InputModels;
public record UserInputModel
{
    public UserInputModel(string name, string suranme, string email, string password, DateTime birthDate, string document, string phoneNumber, RoleEnum role)
    {
        Name = name;
        Suranme = suranme;
        Email = email;
        Password = password;
        BirthDate = birthDate;
        Document = document;
        PhoneNumber = phoneNumber;
        Role = role;
    }

    [MaxLength(50)]
    [Required]
    public string Name { get; set; }
    [MaxLength(50)]
    [Required]
    public string Suranme { get; set; }
    [EmailAddress]
    [Required]
    public string Email { get; set; }
    [Required]
    public string Password { get; set; }
    [Required]
    public DateTime BirthDate { get; set; }
    [Required]
    public string Document { get; set; }
    [Required]
    public string PhoneNumber { get; set; }
    [Required]
    public RoleEnum Role { get; set; }
}
