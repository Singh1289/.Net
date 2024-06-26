namespace PolymorphismExamples
{
    internal class ForeignSales:Sales
    {
        public double SalesNetProfit(double cogs, double expense, double actualSales, int gstPercent,double transportAmount)
        {
            double gstAmount = actualSales * gstPercent / 100;
            return actualSales - (cogs + expense + gstAmount + transportAmount);
        }
        public override int GetGovtGstPercent()
        {
            return base.GetGovtGstPercent()+8;
        }
        public new string GetGstCategory()
        {
            return "Food";
        }
    }
}
