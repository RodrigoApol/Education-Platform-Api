using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.Application.Models.ViewModels;
public record UserViewModel(
    string FullName,
    string Email,
    string Role,
    string Active);
