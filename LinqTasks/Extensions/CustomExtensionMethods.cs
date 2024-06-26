﻿using LinqTasks.Models;

namespace LinqTasks.Extensions;

public static class CustomExtensionMethods
{
    //Put your extension methods here
    public static IEnumerable<Emp> GetEmpsWithSubordinates(this IEnumerable<Emp> emps)
    {
        return emps
    .Where(
        manager => emps
                    .Any(employee => employee.Mgr == manager)
                    )
    .OrderBy(e => e.Ename)
    .ThenByDescending(e => e.Salary);
    }
}