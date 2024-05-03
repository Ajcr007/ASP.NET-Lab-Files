using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

public partial class Employee
{
    public int Eid { get; set; }

    public string? Empname { get; set; }

    public string? Designation { get; set; }
}
