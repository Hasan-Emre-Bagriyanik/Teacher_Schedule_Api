﻿namespace Teacher_Schedule_Api.Dtos.TeacherDtos
{
    public class CreateTeachersDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Branch { get; set; }
        public int WeeklyHours { get; set; }
        public string Image { get; set; }
    }
}
