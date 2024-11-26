using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WD1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<Student> students = new List<Student>
            {
                new Student { ID = 1, NAME = "Thinh", AGE = 25 },
                new Student { ID = 2, NAME = "Huan", AGE = 33 },
                new Student { ID = 3, NAME = "Tung", AGE = 15 },
                new Student { ID = 4, NAME = "Anh", AGE = 17 },
                new Student { ID = 5, NAME = "Hoai", AGE = 16 }
            };

            // In danh sách học sinh
            Console.WriteLine("Danh sach hoc sinh:");
            students.ForEach(s => Console.WriteLine("ID: {0}, Name: {1}, Tuoi: {2}", s.ID, s.NAME, s.AGE));

            // Danh sách học sinh từ 15 đến 18 tuổi
            Console.WriteLine("\nDanh sach hoc sinh tu 15 - 18 tuoi:");
            var ageRangeStudents = students.Where(s => s.AGE >= 15 && s.AGE <= 18).ToList();
            ageRangeStudents.ForEach(s => Console.WriteLine("ID: {0}, Name: {1}, Tuoi: {2}", s.ID, s.NAME, s.AGE));

            // Học sinh có tên bắt đầu bằng chữ "A"
            Console.WriteLine("\nHoc sinh co ten bat dau bang chu 'A':");
            var nameStartWithA = students.Where(s => s.NAME.StartsWith("A", StringComparison.OrdinalIgnoreCase)).ToList();
            nameStartWithA.ForEach(s => Console.WriteLine("ID: {0}, Name: {1}, Tuoi: {2}", s.ID, s.NAME, s.AGE));

            // Tổng tuổi của tất cả học sinh
            int totalAge = students.Sum(s => s.AGE);
            Console.WriteLine("\nTong tuoi cua tat ca hoc sinh trong danh sach: {0}", totalAge);

            // Tìm học sinh có tuổi lớn nhất
            var oldestStudent = students.OrderByDescending(s => s.AGE).First();
            Console.WriteLine("\nHoc sinh co tuoi lon nhat:");
            Console.WriteLine("ID: {0}, Name: {1}, Tuoi: {2}", oldestStudent.ID, oldestStudent.NAME, oldestStudent.AGE);

            // Sắp xếp danh sách theo tuổi tăng dần
            Console.WriteLine("\nDanh sach hoc sinh sau khi sap xep theo tuoi tang dan:");
            var sortedByAge = students.OrderBy(s => s.AGE).ToList();
            sortedByAge.ForEach(s => Console.WriteLine("ID: {0}, Name: {1}, Tuoi: {2}", s.ID, s.NAME, s.AGE));
            Console.ReadLine();
        }
    }
}