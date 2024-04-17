using EducationPlatform.Application.Models.InputModels;
using EducationPlatform.Application.Models.ViewModels.SubscriptionPlan;
using EducationPlatform.Application.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.Application.Services.Interfaces;
public interface ISubscriptionPlanService
{
    Task<List<SubscriptionPlanViewModel>> GetAll();
    Task<Result<SubscriptionPlanDetailsViewModel>> GetById(Guid id);
    Task<Result<Guid>> CreateSubscriptionPlan(SubscriptionPlanInputModel model);
    Task<Result> UpdateSubscriptionPlan(SubscriptionPlanInputModel model, Guid id);
    Task<Result> DeleteSubscriptionPlan(Guid id);
}
