using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationPlatform.Core.Entities;
// Assinatura
public sealed class SubscriptionPlan : BaseEntity
{
    public SubscriptionPlan(string name, int duration)
    {
        Name = name;
        Duration = duration;
        Courses = new List<Course>();
    }

    public string Name { get; private set; }
    public int Duration { get; private set; }
    public List<Course> Courses { get; private set; }

    public void AddCourse(Course course)
    {
        Courses.Add(course);
    }

    public void RemoveCourse(Course course)
    {
        Courses.Remove(course);
    }

    public void UpdateData(string name, int duration)
    {
        Name = name;
        Duration = duration;
    }
}
