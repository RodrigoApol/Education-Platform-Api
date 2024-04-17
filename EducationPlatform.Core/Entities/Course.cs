using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.Core.Entities;
public sealed class Course : BaseEntity
{
    public Course(string name, string description)
    {
        Name = name;
        Description = description;
        Modules = new List<Module>();
    }

    public string Name { get; private set; }
    public string Description { get; private set; }
    public byte[]? Cover { get; private set; }
    public List<Module> Modules { get; private set; }

    public void UploadCover(byte[] cover)
    {
        Cover = cover;
    }

    public void UpdateData(string name, string description)
    {
        Name = name;
        Description = description;
    }
}
