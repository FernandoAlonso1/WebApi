using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    //класс сотрудник
    public class Employee
    {
        public int EmployeeId { get; set; } //id сотрудника
        public string EmployeeName { get; set; } //имя сотрудника
        public string Department { get; set; } //отдел
        public string DateOfJoining { get; set; } //дата начала работы
        public string PhotoFileName { get; set; } //фото
    }
}