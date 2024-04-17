using System;
using System.Collections.Generic;

namespace empAPP_EF.DB;

public partial class EmployeeInfo
{
    public int EmpNo { get; set; }

    public string? EmpName { get; set; }

    public string? EmpDesignation { get; set; }

    public int? EmpSalary { get; set; }

    public bool? EmpIsPermenant { get; set; }
}


