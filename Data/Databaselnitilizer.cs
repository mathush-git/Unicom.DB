using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicom.DB.Data
{
    internal class Databaselnitilizer
    {
        public static void CreateTables()
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();

                cmd.CommandText = @"
                     CREATE TABLE IF NOT EXISTS Course (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL
                    );

                    CREATE TABLE IF NOT EXISTS Student  (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        Address TEXT NOT NULL,                      
                        Password INTEGER NOT NULL,
                        Role TEXT NOT NULL,
                        Course TEXT NOT NULL,
                        CourseId INTEGER,
                        FOREIGN KEY (CourseId) REFERENCES Course(Id)
                        
                    );

                    CREATE TABLE IF NOT EXISTS Lecturer (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        Phone TEXT NOT NULL,
                        Address TEXT NOT NULL,
                        Password TEXT NOT NULL,
                        Role TEXT NOT NULL
                        
                    );

                    CREATE TABLE IF NOT EXISTS Admin (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        Phone TEXT NOT NULL,                       
                        Address TEXT NOT NULL,
                        Password TEXT NOT NULL,
                        Role TEXT 
                        
                    );
                    
                    CREATE TABLE IF NOT EXISTS Staff (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        Phone TEXT NOT NULL,                       
                        Address TEXT NOT NULL,
                        Password TEXT NOT NULL,
                        Role TEXT NOT NULL
                        
                    );

                    CREATE TABLE IF NOT EXISTS User (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        UserId TEXT NOT NULL,
                        Password TEXT NOT NULL,
                        Role TEXT NOT NULL
                    );

                    CREATE TABLE IF NOT EXISTS Student_Lecturers (
                        Stu_Id INTEGER,
                        Lec_Id INTEGER,
                        PRIMARY KEY (Stu_Id, Lec_Id),
                        FOREIGN KEY (Stu_Id) REFERENCES Student(Id),
                        FOREIGN KEY (Lec_Id) REFERENCES Lecturer(Id)
                    );

                    CREATE TABLE IF NOT EXISTS Subject (
                        Subject_Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Subject_Name TEXT NOT NULL,
                        Course_Name TEXT NOT NULL, 
                        Course_Id INTEGER,
                        FOREIGN KEY (Course_Id) REFERENCES Course(Id)
                    );
                    
                    CREATE TABLE IF NOT EXISTS ExamItem (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL                      
                    );

                    CREATE TABLE IF NOT EXISTS Room (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL                      
                    );

                    CREATE TABLE IF NOT EXISTS Exam_Marks (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Exam TEXT NOT NULL,
                        Marks INTEGER NOT NULL,
                        Subject_Name TEXT NOT NULL,
                        Subject_Id INTEGER,
                        Student_Id INTEGER,
                        FOREIGN KEY (Student_Id) REFERENCES Student(Id),
                        FOREIGN KEY (Subject_Id) REFERENCES Subject(Id)
                    );

                    CREATE TABLE IF NOT EXISTS Time_Table (
                        TimeTab_Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Room_Id INTEGER NOT NULL,
                        Room_Name TEXT NOT NULL,
                        Subject TEXT NOT NULL,
                        Subject_Id INTEGER,
                        TimeSlot TEXT NOT NULL,
                        FOREIGN KEY (Subject_Id) REFERENCES Subject(Id)
                    );

                    CREATE TABLE IF NOT EXISTS Lecturers_Course (
                        Lec_Id INTEGER,
                        Course_Id INTEGER,
                        PRIMARY KEY (Lec_Id, Course_Id),
                        FOREIGN KEY (Lec_Id) REFERENCES Lecturer(Id),
                        FOREIGN KEY (Course_Id) REFERENCES Course(Id)
                    );

                ";

                cmd.ExecuteNonQuery();
            }
        }
    }
}
