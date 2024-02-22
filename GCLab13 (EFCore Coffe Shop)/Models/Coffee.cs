using System;
using System.Collections.Generic;

namespace GCLab13__EFCore_Coffe_Shop_.Models;

public partial class Coffee
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public float? Price { get; set; }

    public string? Category { get; set; }
}
