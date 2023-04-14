﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace DxAccordionGettingStarted {
    public class MainWindowViewModel {
        public MainWindowViewModel() {
            var employeeDepartments = Staff.GetStaff()
                .GroupBy(x => x.Department)
                .Select(x => new EmployeeDepartment(x.Key, x.ToArray()));
            EmployeeDepartments = new ObservableCollection<EmployeeDepartment>(employeeDepartments.ToArray());
        }
        public ObservableCollection<EmployeeDepartment> EmployeeDepartments { get; set; }
    }

    public class EmployeeDepartment {
        public string Name { get; set; }
        public ObservableCollection<Employee> Employees { get; set; }

        public EmployeeDepartment(string name, IEnumerable<Employee> employees) {
            Name = name;
            Employees = new ObservableCollection<Employee>(employees);
        }
        public override string ToString() {
            return Name;
        }
    }
}
