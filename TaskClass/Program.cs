Student student1= new Student("Zeynab", "Rahimli", "P237", 90, false);
student1.Name = "Zeyneb";
student1.Surname = "Rehimli";
student1.Group = "P237";
student1.Point = 90;
student1.isGraduated = false;

Console.WriteLine(student1.ShowFullname() );
Console.WriteLine( student1.ShowFullInfo());
Console.WriteLine(student1.ExamInfo());    