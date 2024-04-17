using EducationPlatform.Core.Entities.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.Core.Entities;
public sealed class TutorialCompletedUser : BaseEntity
{
    public TutorialCompletedUser(Guid idUser, Guid idTutorial, Review review)
    {
        IdUser = idUser;
        IdTutorial = idTutorial;
        ConclusionDate = DateTime.Now;
        Review = review ?? null;
    }

    public Guid IdUser { get; private set; }
    public Guid IdTutorial { get; private set; }
    public DateTime ConclusionDate { get; private set; }
    public Review? Review { get; private set; }
    public User User { get; private set; } = null!;
    public Tutorial Tutorials { get; private set; } = null!;
}
