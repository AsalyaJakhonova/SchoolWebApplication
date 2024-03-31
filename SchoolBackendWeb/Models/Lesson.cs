namespace SchoolBackendWeb.Models
{
    public class Lesson
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public string LessonType { get; set; }
        public string StudentName { get; set; }
        public string TeacherName { get; set; }
        public string Duration { get; set; }
    }
}
