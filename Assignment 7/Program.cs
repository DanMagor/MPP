using System;
using System.Collections.Generic;

namespace Assignment6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Basic instances initialization.
            var year = new Year("BS2");               
            var name = new Name("Ivan", "Tkachenko");
            var instructorName = new Name("Evgeniy", "Zuev");
            var assistantName = new Name("Evgeniy", "Bobrov");
            var instructor = new Instructor(instructorName);
            var assistant = new Assistant(assistantName);
          
            //Create array of Assistants for course.
            Assistant[] mppAssistants = {assistant};
            
            //Create course.
            var lectureCourse = new LectureCourse("MPP", year, instructor, mppAssistants, true);
            
            //Array of courses.
            LectureCourse[] lectureCourses = {lectureCourse};
            
            //Some additional basic instanceses.
            var student = new Student(name, year, lectureCourses);
            var auditorium = new Auditorium("Fri", "09:00", 106);
            var lecture = new Lecture(lectureCourse, auditorium);
            
            //Array of lectures
            Lecture[] lectures = {lecture};
            
            //Create a day and fill week with the same day, just for demostration. 
            var exampleDay = new TeachingDay(lectures);
            var teachingWeek = new TeachingWeek(exampleDay, exampleDay, exampleDay, exampleDay, exampleDay, exampleDay,
                exampleDay);
            
            //Array of weeks with one week for schedule.
            TeachingWeek[] teachingWeeks = {teachingWeek};
            var teachingSchedule = new TeachingSchedule(teachingWeeks);

            //Create arrays with one element for university object.
            Student[] students = {student};
            Instructor[] instructors = {instructor};
            Assistant[] assistants = mppAssistants;

            //Create University
            var innopolisUniversity =
                new University(students, assistants, instructors, lectureCourses, teachingSchedule);

            
            //Some output demonstration, set operation works as well.
            Console.Write(innopolisUniversity.Students[0].Name.GivenName + " " +
                          innopolisUniversity.Students[0].Name.FamilyName);
            Console.Write(" Year:" + innopolisUniversity.Students[0].Year.Value + " ");
            Console.Write(" Study: ");
            Console.WriteLine(innopolisUniversity.Courses[0].Title);
            Console.WriteLine("by " + innopolisUniversity.Courses[0].Instructor.Name.GivenName + " " +
                              innopolisUniversity.Courses[0].Instructor.Name.FamilyName + " with " +
                              innopolisUniversity.Courses[0].Assistants[0].Name.GivenName + " " +
                              innopolisUniversity.Courses[0].Assistants[0].Name.FamilyName);
            Console.Write("There is: " + innopolisUniversity.Schedule.Weeks[0].Friday.Lectures[0].Course.Title +
                          " at " + innopolisUniversity.Schedule.Weeks[0].Friday.Lectures[0].Room.DayTime + " in " +
                          innopolisUniversity.Schedule.Weeks[0].Friday.Lectures[0].Room.RoomNo);
        }
    }
}