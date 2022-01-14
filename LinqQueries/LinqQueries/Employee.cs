﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQueries
{
    public class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public double Age { get; set; }
        public Gender Sex { get; set; }
        public string Dept { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }

        public static List<Employee> student_data = new List<Employee>();

        public static void EmployeeData()
        {
            student_data.Clear();
            student_data.Add(new Employee {ProjectId = 1,   Name = "Mizanur Rahaman", Id = 1, Dept = "CSE", Age = 25, Sex = Gender.Male });
            student_data.Add(new Employee {ProjectId = 1,   Name = "Mizanur rahaman", Id = 1, Dept = "CSE", Age = 25, Sex = Gender.Male });
            student_data.Add(new Employee {ProjectId = 1,   Name = "Mithun ali", Id = 3, Age = 26, Dept = "CSE", Sex = Gender.Female });
            student_data.Add(new Employee {ProjectId = 1,   Name = "Samsur rahaman", Id = 5, Dept = "CSE", Age = 24, Sex = Gender.Male });
            student_data.Add(new Employee {ProjectId = 1,   Name = "Habibur rahaman", Id = 8, Dept = "CSE", Age = 20, Sex = Gender.Female });
            student_data.Add(new Employee {ProjectId = 1,   Name = "Mustafizur rahaman", Id = 4, Age = 29, Dept = "CSE", Sex = Gender.Male });
            student_data.Add(new Employee {ProjectId = 1,   Name = "Mizanur rahaman", Id = 10, Age = 20, Dept = "CSE", Sex = Gender.Other });
            student_data.Add(new Employee {ProjectId = 1,   Name = "Mithun ali", Id = 13, Age = 22, Dept = "CSE", Sex = Gender.Other });
            student_data.Add(new Employee {ProjectId = 1,   Name = "Samsur rahaman", Id = 15, Age = 25, Dept = "CSE", Sex = Gender.Other });
            student_data.Add(new Employee {ProjectId = 1,   Name = "Habibur rahaman", Id = 18, Dept = "CSE", Age = 24, Sex = Gender.Male });
            student_data.Add(new Employee {ProjectId = 1,   Name = "Mustafizur rahaman", Id = 14, Dept = "CSE", Age = 25, Sex = Gender.Female });
        }

        public enum Gender
        {
            Male = 1,
            Female = 2,
            Other = 3
        }
    }
}