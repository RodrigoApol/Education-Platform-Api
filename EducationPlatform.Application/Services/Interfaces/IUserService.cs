using EducationPlatform.Application.Models.InputModels;
using EducationPlatform.Application.Models.ViewModels;
using EducationPlatform.Application.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.Application.Services.Interfaces;
public interface IUserService
{
    Task<List<UserViewModel>> GetAll();
    Task<Result<UserViewModel>> GetById(Guid id);
    Task<Result<Guid>> CreateUser(UserInputModel model);
    Task<Result> UpdateUser(UserInputModel model, Guid id);
    Task<Result> Deleteuser(Guid id);
}
