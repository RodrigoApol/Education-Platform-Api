using EducationPlatform.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.Core.Entities;
public sealed class SubscriptionPlanUser : BaseEntity
{
    public SubscriptionPlanUser(Guid idUser, Guid idSibscriptionPlan, DateTime initialDate, DateTime expireDate)
    {
        IdUser = idUser;
        IdSibscriptionPlan = idSibscriptionPlan;
        Status = SubscriptionPlanUserSatusEnum.Pending;
        InitialDate = initialDate;
        ExpireDate = expireDate;
    }

    public Guid IdUser { get; private set; }
    public Guid IdSibscriptionPlan { get; private set; }
    public SubscriptionPlanUserSatusEnum Status { get; private set; }
    public DateTime InitialDate { get; private set; }
    public DateTime ExpireDate { get; private set; }
    public User User { get; private set; } = null!;
    public SubscriptionPlan SubscriptionPlan { get; private set; } = null!;

    //TODO: Criar Métodos para modificar Status
}
