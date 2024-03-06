namespace ToTheMoon
{
    public class Motor
    {
        public int ActivationCode { get; set; }

        public Motor(int activationCode)
        {
            ActivationCode = activationCode;
        }

        public static Motor FabricateMotor()
        {
            return new Motor(new Random().Next(1, 20));
        }

        public void Activate(int actCode, int fuel)
        {
            if (actCode == ActivationCode && fuel > 0)
            {
                Console.WriteLine("Motor activated successfully.");
            }
            else if (actCode != ActivationCode) 
            {
                Console.WriteLine("Cannot activate: The activation code is incorrect.");
            }
            else
            {
                Console.WriteLine("Cannot activate: Not enough fuel.");
            }
        }

        public void Stop()
        {
            Console.WriteLine("Stopping motor.");
        }
    }
}
