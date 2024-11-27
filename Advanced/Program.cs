



using Advanced;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

public class Program
{
    public static void Main(string[] args)
    {
        
        List<Student> students = new List<Student>();
        students.Add(new Student { Id = 1, Name = "Ali" });
        students.Add(new Student { Id = 2, Name = "Ayşe" });
        students.Add(new Student { Id = 3, Name = "Ahmet" });

        List<Grade> grades = new List<Grade>();

        grades.Add(new Grade { StudentId = 1, Course = "Matematik", Score = 100 });
        grades.Add(new Grade { StudentId = 2, Course = "Matematik", Score = 76 });
        grades.Add(new Grade { StudentId = 3, Course = "Matematik", Score = 10 });
        grades.Add(new Grade { StudentId = 2, Course = "Tarih", Score = 65 });
        grades.Add(new Grade { StudentId = 3, Course = "İngilizce", Score = 73 });
        grades.Add(new Grade { StudentId = 3, Course = "Türkçe", Score = 70 });

        /*
        //var studentGrades = students.Join(grades,
           // student => student.Id,
           // grade => grade.StudentId,
           // (student, grade) => new
           // {
            //    StudentName = student.Name,
           //     CourseName = grade.Course,
           //     Score = grade.Score
           // }
           // );
        

        var studentGrades = from student in students
                            join grade in grades on student.Id equals grade.StudentId
                            select new
                            {
                                StudentName = student.Name,
                                CourseName =grade.Course,
                                Score =grade.Score,
                            };
        foreach (var student in studentGrades)
        {
            Console.WriteLine($"Öğrenci Adı {student.StudentName} ders {student.CourseName} Not {student.Score}");
        }

        Console.WriteLine("-------------");

        var studentsWithGrades = students.GroupJoin(grades, 
                                                    student => student.Id, 
                                                    grade => grade.StudentId,
                                                    (student, studentGrades) => new 
                                                    {
                                                        StudentName = student.Name,
                                                        Grades = studentGrades
                                                    }
                                                    );

        foreach (var student in studentsWithGrades)
        {
            Console.WriteLine($"{student.StudentName}");
            Console.WriteLine($"----- Dersleri");
            foreach (var grade in student.Grades)
            {
                Console.WriteLine($"{grade.Course} -- {grade.Score}");
            }
        }
        

        var numbers = new List<int>() { 1,2,3,4,5,6,7,8,9 };
        var grupedAndSummed = numbers.GroupBy(num => num % 2 == 0 ? "Çift" : "Tek")
                                        .Select(group => new
                                        {
                                            Key = group.Key,
                                            Sum = group.Sum(),
                                        });

        foreach (var group in grupedAndSummed)
        {
            Console.WriteLine($"{group.Key} : toplam {group.Sum}");
        }
        


        var studentsAverageGrades = students.Select(student => new
        {
            StudentName = student.Name,
            AverageGrade = grades.Where(s => s.StudentId == student.Id).Average(g => g.Score)
        });

        foreach (var student in studentsAverageGrades)
        {
            Console.WriteLine($"{student.StudentName} ortalama: {student.AverageGrade}");
        }
        */


        var pageStudents = students.OrderBy(student => student.Name)
                                     .Skip(0)
                                     .Take(1);



    }







}