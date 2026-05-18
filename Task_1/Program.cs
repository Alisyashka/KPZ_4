namespace Task_1
{
    internal class Program
    {
        static void Main()
        {
            var basic = new BasicSupport();
            var billing = new BillingSupport();
            var tech = new TechnicalSupport();
            var senior = new SeniorSupport();

            basic.SetNext(billing);
            billing.SetNext(tech);
            tech.SetNext(senior);

            var menu = new SupportMenu(basic);
            menu.Start();
        }
    }
}