using EducationPlatform.Application.Models.ViewModels.Course;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.Application.Models.ViewModels.SubscriptionPlan;
public record SubscriptionPlanDetailsViewModel(
    string Name,
    string Duration,
    List<CourseViewModel> Courses);
