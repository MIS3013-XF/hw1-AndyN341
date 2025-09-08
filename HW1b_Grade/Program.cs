// HW1b Grade

// Your Name: Andy Nguyen
// Did you seek help ? If yes, specify the helper or web link here: No

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace HW1b_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string FirstName;
            string LastName;
            string StudentID;
            double Homework;
            double Participation;
            double Exam1;
            double Exam2;
            double Exam3;
            double Total;

            const double WeightHW = 0.2;
            const double WeightPart = 0.15;
            const double WeightExam1 = 0.15;
            const double WeightExam2 = 0.25;
            const double WeightExam3 = 0.25;

            string HomeworkAsString;
            string ParticipationAsString;
            string Exam1AsString;
            string Exam2AsString;
            string Exam3AsString;

            Console.WriteLine("What is your first name?");
            FirstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            LastName = Console.ReadLine();

            Console.WriteLine("What is your student id?");
            StudentID = Console.ReadLine();

            Console.WriteLine("What is your overall percentage grade for homeworks?");
            HomeworkAsString = Console.ReadLine();

            Homework = Convert.ToDouble(HomeworkAsString);
            Homework = Homework * WeightHW;

            Console.WriteLine("What is your overall percentage grade for participations?");
            ParticipationAsString = Console.ReadLine();

            Participation = Convert.ToDouble(ParticipationAsString);
            Participation = Participation * WeightPart;

            Console.WriteLine("What is your overall percentage grade for exam 1?");
            Exam1AsString = Console.ReadLine();

            Exam1 = Convert.ToDouble(Exam1AsString);
            Exam1 = Exam1 * WeightExam1;

            Console.WriteLine("What is your overall percentage grade for exam 2?");
            Exam2AsString = Console.ReadLine();

            Exam2 = Convert.ToDouble(Exam2AsString);
            Exam2 = Exam2 * WeightExam2;

            Console.WriteLine("What is your overall percentage grade for exam 3?");
            Exam3AsString = Console.ReadLine();

            Exam3 = Convert.ToDouble(Exam3AsString);
            Exam3 = Exam3 * WeightExam3;

            Total = Homework + Participation + Exam1 + Exam2 + Exam3;

            Console.WriteLine(FirstName + " " + LastName + " (" +  StudentID + "), your final grade is " + Total.ToString("N2") + "%");
        }
    }
}
