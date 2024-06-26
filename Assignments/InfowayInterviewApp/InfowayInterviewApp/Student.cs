using System;

namespace InfowayInterviewApp
{
    public delegate void InterviewBasket();
    internal class Student
    {
        //Actions/Events
        public event InterviewBasket OnSelection;
        public event InterviewBasket OnRejection;
        public int StudentId { get; set; }
        public string StudentName { get; set;}
        public string Email { get; set;}
        public string Phone { get; set;}
        public int TotalMarks { get; set; }
        //public string CalculateResult(int totalMarks,out string companyName)
        //{
        //    companyName = "Infosys Ltd.";
        //    if (totalMarks>80)
        //    {
        //        return string.Format($"Student {StudentName} has been selected for next round of interview!");
        //    }
        //    else
        //    {
        //        return string.Format($"Student {StudentName} has been rejected for next round of interview!");
        //    }
        //}
        public string CalculateResult(int totalMarks, ref string companyName)
        {
            companyName = "Infosys Ltd.";
            if (totalMarks > 80)
            {
                if (OnSelection!=null)
                {
                    OnSelection();
                }
                return string.Format($"Student {StudentName} has been selected for next round of interview!");
            }
            else
            {
                if (OnRejection!=null)
                {
                    OnRejection();
                }
                return string.Format($"Student {StudentName} has been rejected for next round of interview!");
            }
        }
        public void InterviewCities(params string[] cities)
        {
            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }
}
