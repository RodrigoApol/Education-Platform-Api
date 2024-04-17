using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.Core.Entities;
public abstract class BaseEntity
{
    public BaseEntity()
    {
        Id = new Guid();
        CreatedAt = DateTime.Now;
        IsActive = true;
    }

    public Guid Id { get; init; }
    public DateTime CreatedAt { get; private set; }
    public bool IsActive { get; private set; }

    public void Delete()
    {
        IsActive = false;
    }
}
