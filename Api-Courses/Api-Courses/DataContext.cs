using Api_Courses.Entities;

namespace Api_Courses
{
    public class DataContext
    {
        public  List<User> Users { get; set; }

        public  List<Category> Categories { get; set; }  

        public List<Lecturer> lecturers { get; set; }

        public List<Courses> Courses { get; set; }

        public DataContext()
        {
            Users = new List<User>
            {
                  new User{Id= 123, Name="Chani", Adress="Harishonim",Email="123@gmail.com",Password="C123"},
                  new User{Id= 124, Name="Adi", Adress="ChazonEish",Email="124@gmail.com",Password="A124"}
            };

            Categories = new List<Category>
            {
                new Category{Id=1 , Name="Angular", Routing="D:\\שנה ב\\Angular\\Courses-Project\\Images\\imgemail"}
            };

            lecturers = new List<Lecturer>
            {
                new Lecturer{Id=1001, Name="Noa",Adress="Harishonim",Email="1001@gmail.com",Password="C1001"},
                new Lecturer{Id=1002, Name="Soshana",Adress="RabbiAkiva",Email="1002@gmail.com",Password="C1002"},
            };

            Courses = new List<Courses>
            {
                new Courses{Id=10,AmountLesson=5,Image="hhhyy",CategoryId=2,LectuerId=6,Name="Moshe",StartDate=new DateTime(1/2/2024),Syllabus=new List<string>{"Java","C++","React"},WayLearning=WayLearning.Zoom },
                new Courses{Id=11,AmountLesson=7,Image="hhhh",CategoryId=3,LectuerId=7,Name="chaim",StartDate=new DateTime(1/3/2024),Syllabus=new List<string>{"C#","English"},WayLearning=WayLearning.Frontal },
            };
        }

    }
}
