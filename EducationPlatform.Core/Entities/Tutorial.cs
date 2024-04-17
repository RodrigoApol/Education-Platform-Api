using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.Core.Entities;
public sealed class Tutorial : BaseEntity
{
    public Tutorial(string name, string description, string linkVideo, int duration)
    {
        Name = name;
        Description = description;
        LinkVideo = linkVideo;
        Duration = duration;
    }

    public string Name { get; private set; }
    public string Description { get; private set; }
    public string LinkVideo { get; private set; }   
    public int Duration { get; private set; }
}
