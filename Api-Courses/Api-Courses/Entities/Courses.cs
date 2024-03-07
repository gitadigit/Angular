namespace Api_Courses.Entities
{
  public  enum WayLearning { Frontal,Zoom }

    public class Courses
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        public int CategoryId { get; set; }
        
        public int AmountLesson { get; set; }
        
        public DateTime StartDate { get; set; }
        
        public List<string> Syllabus { get; set; }

        public WayLearning WayLearning { get; set; }

        public int LectuerId { get; set; }

        public string Image { get; set; }

    }
}
