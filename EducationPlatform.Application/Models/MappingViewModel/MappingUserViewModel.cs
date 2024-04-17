using EducationPlatform.Application.Models.ViewModels;
using EducationPlatform.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.Application.Models.MappingViewModel;
public static class MappingUserViewModel
{
    public static List<UserViewModel> ToViewModel(this IEnumerable<User> users)
    {
        return users
            .Select(u => new UserViewModel(
                u.Name + " " + u.Surname,
                u.Email,
                u.Role.ToString(),
                u.IsActive.ToString()))
            .ToList();
    }

    public static UserViewModel ToViewModelWithId(this User user)
    {
        return new(
            user.Name + " " + user.Surname,
            user.Email,
            user.Role.ToString(),
            user.IsActive.ToString());
    }
}
