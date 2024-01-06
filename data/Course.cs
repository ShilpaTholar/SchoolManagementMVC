using System;
using System.Collections.Generic;

namespace project.data;

public partial class Course
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Code { get; set; }

    public int? Credits { get; set; }

    public virtual ICollection<Class> Classes { get; set; } = new List<Class>();
}
