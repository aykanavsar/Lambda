using LinqGroupJoin;

public class Program
{
    public static void Main(string[] args)
    {
        List<Student> students = new List<Student>();
        students.Add(new Student { studentId = 1 , studentName = "Ali" , sclassId = 1});
        students.Add(new Student { studentId = 2, studentName = "Ayşe", sclassId = 2 });
        students.Add(new Student { studentId = 3, studentName = "Mehmet", sclassId = 1 });
        students.Add(new Student { studentId = 4, studentName = "Fatma", sclassId = 3 });
        students.Add(new Student { studentId = 5, studentName = "Ahmet", sclassId = 2 });

        List<Sinif> sinifs = new List<Sinif>();
        sinifs.Add(new Sinif { classId = 1, className = "Matematik" });
        sinifs.Add(new Sinif { classId = 1, className = "Türkçe" });
        sinifs.Add(new Sinif { classId = 1, className = "Kimya" });

        var studentssinifs = students.GroupJoin(sinifs,
                                                student => student.sclassId,
                                                sinif => sinif.classId,
                                                (student, studentsinif) => new
                                                {
                                                    studentname = student.studentName,
                                                    sinifs = studentsinif
                                                }
                                                );

        foreach (var student in studentssinifs)
        {
            Console.WriteLine("-------------");
            Console.WriteLine($"{student.studentname}");
            Console.WriteLine("----> Dersler");
            foreach (var sinif in student.sinifs)
            {
                Console.WriteLine($"{sinif.className}");
            }
        }



    }
}