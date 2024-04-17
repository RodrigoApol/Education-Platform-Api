using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.Application.Models.InputModels;
public record SubscriptionPlanInputModel
{
    public SubscriptionPlanInputModel(string name, int duration)
    {
        Name = name;
        Duration = duration;
    }

    public string Name { get; set; }
    public int Duration { get; set; }
}
