using linqpractices.DbOperations;
using linqpractices.Entities;
using System;

DataGenerator.Initialize();
LinqDbContext _context = new();
var students = _context.Students.ToList<Student>();
//Find()
var student = _context.Students.Where(student => student.StudentId == 1).FirstOrDefault();
student = _context.Students.Find(1);


Console.WriteLine(student.Name);
//firstordefault

student= _context.Students.Where(student => student.Surname =="Kaya").FirstOrDefault();
Console.WriteLine(student.Name);

student = _context.Students.FirstOrDefault(x => x.Surname == "Kaya");
Console.WriteLine(student.Name);

//single or default
student=_context.Students.SingleOrDefault(student=> student.Name=="Kaplan");
Console.WriteLine(student.Surname);
//student = _context.Students.SingleOrDefault(student => student.Name == "Ali");
//singleordefault tekil değerler için geçerlidir. örnekte aynı adda
//iki kişi vardı o yüzden hata fırlattı.
//ToList()

var studentList= _context.Students.Where(student=>student.ClassId == 3).ToList();
Console.WriteLine(studentList.Count);

//OrderBy
students=_context.Students.OrderBy(x=>x.StudentId).ToList();
foreach (var st in students)
{
    Console.WriteLine(st.StudentId+ "-"+ st.Name);
    
    
}
//OrderByDescending
students = _context.Students.OrderByDescending(x => x.StudentId).ToList();
foreach (var st in students)
{
    Console.WriteLine(st.StudentId + "-" + st.Name);


}
//Anonymous Object Result
var anonymousObject = _context.Students.
    Where(x => x.ClassId == 2).
    Select(x => new
    {
        Id = x.StudentId,
        FullName = x.Name + " " + x.Surname
    });
foreach (var anon in anonymousObject)
{
    Console.WriteLine(anon.Id+"-"+anon.FullName);
}




