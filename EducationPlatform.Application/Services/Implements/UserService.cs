using EducationPlatform.Application.Errors;
using EducationPlatform.Application.Models.InputModels;
using EducationPlatform.Application.Models.MappingViewModel;
using EducationPlatform.Application.Models.ViewModels;
using EducationPlatform.Application.Results;
using EducationPlatform.Application.Services.Interfaces;
using EducationPlatform.Core.Entities;
using EducationPlatform.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.Application.Services.Implements;
public class UserService : IUserService
{
    private readonly IRepositoryBase<User> _repository;

    public UserService(IRepositoryBase<User> repository)
    {
        _repository = repository;
    }

    public async Task<Result<Guid>> CreateUser(UserInputModel model)
    {
        var newUser = new User(
            model.Name,
            model.Suranme,
            model.Email,
            model.Password,
            model.Document,
            model.BirthDate,
            model.PhoneNumber,
            model.Role);

        await _repository.AddAsync(newUser);

        return Result.Success(newUser.Id);
    }

    public async Task<Result> Deleteuser(Guid id)
    {
        var user = await _repository.GetByIdAsync(id);

        if (user is null)
        {
            return Result.Fail(Error.NotFound(id));
        }

        user.Delete();

        return Result.Success();
    }

    public async Task<List<UserViewModel>> GetAll()
    {
        var users = await _repository.GetAllAsync();

        var usersViewModel = users.ToViewModel();

        return usersViewModel;
    }

    public async Task<Result<UserViewModel>> GetById(Guid id)
    {
        var user = await _repository.GetByIdAsync(id);

        if (user is null)
        {
            return Result.Fail<UserViewModel>(Error.NotFound(id));
        }

        var userViewModel = user.ToViewModelWithId();

        return Result.Success(userViewModel);
    }

    public async Task<Result> UpdateUser(UserInputModel model, Guid id)
    {
        var user = await _repository.GetByIdAsync(id);

        if (user is null)
        {
            return Result.Fail(Error.NotFound(id));
        }

        user.UpdateData(model.Name, model.Suranme, model.Email, model.PhoneNumber);

        return Result.Success();
    }
}
