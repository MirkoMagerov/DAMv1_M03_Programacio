using System;

namespace Workers
{
    public class FullTimeWorker : Worker
    {
        public int HoursWorked { get; set; }

        public FullTimeWorker(string name, double salaryRate, int hoursWorked) : base(name, salaryRate)
        {
            HoursWorked = hoursWorked;
        }

        public override double ComputePay()
        {
            return HoursWorked * SalaryRate;
        }
    }
}
