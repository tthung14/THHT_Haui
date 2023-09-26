using bai5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace bai5.Controllers
{
    public class EmployeeController : ApiController
    {
        List<Employee> list;
        public EmployeeController() 
        {
            list = new List<Employee>();
            list.Add(new Employee(1, "Tuan Hung", "Bac Ninh", 3000));
            list.Add(new Employee(2, "Phuong Dung", "Ha Noi", 1000));
            list.Add(new Employee(3, "Thi Thoa", "Hai Duong", 2000));
            list.Add(new Employee(4, "Quynh Anh", "Thai Binh", 1500));
            list.Add(new Employee(5, "Minh Hue", "Nam Dinh", 2500));
        }

        // tao api dau tien lay ra danh sach employee
        [HttpGet] // them dia chi gui
        public List<Employee> GetAllEmployees()
        {
            return list;
        }

        // lay ra danh sach employee theo dia chi
        [HttpGet]
        [Route("api/employee/listbyaddress")]// dinh tuyen lai api co mo ta ten phuong thuc
        public List<Employee> GetAllEmployeesByAddress(string address)
        {
            List<Employee> list2 = new List<Employee>();
            foreach (Employee emp in list)
            {
                if (emp.address == address)
                {
                    list2.Add(emp);
                }
            }
            return list2;
        }

        // tim nhan vien theo id
        [HttpGet]
        [Route("api/employee/find")]
        public Employee FindEmployee(int empid)
        {
            Employee e = new Employee();
            e.empid = empid;
            int index = list.IndexOf(e);
            if (index != -1)
            {
                return list[index];
            }
            else {
                return null;
            }
        }

        // them nhan vien
        [HttpPost]
        [Route("api/employee/add")]
        public int AddEmployee([FromBody] Employee emp)
        {
            list.Add(emp);
            return list.Count;
        }

        // cap nhat du lieu
        [HttpPut]
        [Route("api/employee/put")]
        public string TestPut()
        {
            return "Test put method";
        }

        // xoa du lieu
        [HttpDelete]
        [Route("api/employee/delete")]
        public string TestDelete()
        {
            return "Test delete method";
        }
    }
}
