using System;

namespace InfowayInterviewApp
{
	internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
				Student student=new Student();
				student.OnSelection += new InterviewBasket(OracleDb);
				student.OnSelection += new InterviewBasket(ExcelDb);
				student.OnRejection+= new InterviewBasket(MsSqlServerDb);
				student.StudentId = 1;
				student.StudentName = "Test";
				student.Email = "Test";
				student.Phone= "37483434";
				student.TotalMarks = 87;
				if (student.TotalMarks>80 && student.TotalMarks<95)
				{
                    student.OnSelection -= new InterviewBasket(ExcelDb);
                }
				string company=string.Empty;
				string result = student.CalculateResult(student.TotalMarks,ref company);
				Console.WriteLine(result);
				Console.WriteLine($"Interview for the Company - {company}!");
				student.InterviewCities("Pune", "Bangalore", "Delhi", "Chennai");
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			Console.ReadKey();
        }

		private static void OracleDb()
		{
			Console.WriteLine("Data is stored in Oracle DB!");
		}
        private static void ExcelDb()
        {
            Console.WriteLine("Data is stored in Excel DB!");
        }
        private static void MsSqlServerDb()
        {
            Console.WriteLine("Data is stored in Microsoft SQL Server DB!");
        }
    }
}
