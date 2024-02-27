using System;

namespace Workers
{
    public class HourlyWorker : Worker
    {
        public int HoursWorked { get; set; }

        public HourlyWorker(string name, double salaryRate, int hoursWorked) : base(name, salaryRate)
        {
            HoursWorked = hoursWorked;
        }

        public override double ComputePay()
        {
            return HoursWorked * SalaryRate;
        }
    }
}
