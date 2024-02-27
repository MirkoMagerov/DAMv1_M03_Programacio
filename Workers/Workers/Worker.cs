using System;

namespace Workers
{
    public abstract class Worker
    {
        public string Name { get; set; }
        public double SalaryRate { get; set; }

        public Worker(string name, double salaryRate)
        {
            Name = name;
            SalaryRate = salaryRate;
        }

        public abstract double ComputePay();
    }
}
