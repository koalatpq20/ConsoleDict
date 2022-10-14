using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDict
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            // Khởi tạo Dictionary quản lý nhân viên
            Dictionary<string, Employee> employees = new Dictionary<string, Employee>();

            Console.WriteLine("Nhập phím bất kỳ để nhập thông tin nhân viên - Nhập Esc để ngưng nhập thông tin \n");

            // Nhập thông tin nhân viên đến khi bấm Esc
            while (Console.ReadKey(false).Key != ConsoleKey.Escape)
            {
                Console.WriteLine("Nhập nhân viên : ");
                Employee employee = new Employee() { ID = Console.ReadLine(), Name = Console.ReadLine(), Age = Convert.ToInt16(Console.ReadLine()) };
                employees.Add(employee.ID, employee);
            }

            Console.WriteLine("Nhập danh sách nhân viên thành công");

            Console.WriteLine("Nhập mã nhân viên muốn tìm kiếm");
            string id = Console.ReadLine();

            if (employees.ContainsKey(id)) //Kiểm tra ID có chưa trong Key của Dictionary không
                Console.WriteLine(employees[id].Information);
            else
                Console.WriteLine($"Không tìm thấy nhân viên có mã {id}");

            Console.WriteLine($"Tổng số nhân viên hiện có : {employees.Count}");

            Console.ReadLine();
        }
    }
}
