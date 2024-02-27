namespace Workers
{
    class Program
    {
        public static void Main()
        {
            const int MAX_HOURLY_WORK_HOURS = 60, MAX_FULLTIME_WORK_HOURS = 240;
            const string MSG_MORE_HOURS_DONE = "El trabajador {0} ha hecho más horas de las permitidas.";
            const string MSG_SHOW_PAY = "Salario de el trabajador {0}: {1}";

            HourlyWorker hourlyWorker1 = new HourlyWorker("Bobo1", 5, 50);
            HourlyWorker hourlyWorker2 = new HourlyWorker("Bobo2", 5, 75);

            FullTimeWorker fullTimeWorker1 = new FullTimeWorker("Bobo3", 10, 200);
            FullTimeWorker fullTimeWorker2 = new FullTimeWorker("Bobo4", 10, 280);

            if (hourlyWorker1.HoursWorked < MAX_HOURLY_WORK_HOURS)
            {
                Console.WriteLine(MSG_SHOW_PAY, hourlyWorker1.Name, hourlyWorker1.ComputePay());
            }
            else
            {
                Console.WriteLine(MSG_MORE_HOURS_DONE, hourlyWorker1.Name);
            }

            if (hourlyWorker2.HoursWorked < MAX_HOURLY_WORK_HOURS)
            {
                Console.WriteLine(MSG_SHOW_PAY, hourlyWorker2.Name, hourlyWorker2.ComputePay());
            }
            else
            {
                Console.WriteLine(MSG_MORE_HOURS_DONE, hourlyWorker2.Name);
            }

            if (fullTimeWorker1.HoursWorked < MAX_FULLTIME_WORK_HOURS)
            {
                Console.WriteLine(MSG_SHOW_PAY, fullTimeWorker1.Name, fullTimeWorker1.ComputePay());
            }
            else
            {
                Console.WriteLine(MSG_MORE_HOURS_DONE, fullTimeWorker1.Name);
            }

            if (fullTimeWorker2.HoursWorked < MAX_FULLTIME_WORK_HOURS)
            {
                Console.WriteLine(MSG_SHOW_PAY, fullTimeWorker2.Name, fullTimeWorker2.ComputePay());
            }
            else
            {
                Console.WriteLine(MSG_MORE_HOURS_DONE, fullTimeWorker2.Name);
            }
        }
    }
}