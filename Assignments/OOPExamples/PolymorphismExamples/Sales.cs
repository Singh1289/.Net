//SalesNetProfit = Incoming Money - Outgoing Money
//Outgoing Money - COGS, Expense, Gst
//Incoming Money - ActualSales

namespace PolymorphismExamples
{
    internal class Sales
    {
        public double SalesNetProfit(double cogs, double expense, double actualSales)
        {
            return actualSales - (cogs + expense);
        }
        public double SalesNetProfit(double cogs, double expense, double actualSales, int gstPercent)
        {
            double gstAmount = actualSales * gstPercent / 100;
            return actualSales - (cogs + expense + gstAmount);
        }
        public virtual int GetGovtGstPercent()
        {
            return 10;
        }
        public string GetGstCategory()
        {
            return "Information Technology";
        }

    }
}
