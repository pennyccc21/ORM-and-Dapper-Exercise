﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Dapper
{
    internal interface IDepartmentRepository
    {
        IEnumerable<Department> GetAllDepartments(); //Stubbed out method

        void InsertDepartment(string newDepartmentName);
    }
}
