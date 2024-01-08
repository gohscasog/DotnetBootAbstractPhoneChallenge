namespace Project.Models
{
    abstract class Phone
    {
        public Phone(string number)
        {
            this.number = number;
        }

        public void Call(string number)
        {
            System.Console.WriteLine($"Calling {number}...");
        }

        public void Answer()
        {
            System.Console.WriteLine("Answering incoming call...");
        }

        public abstract void InstallApp(string path);

        public string number = string.Empty;

        string model = string.Empty;
        string imei = string.Empty;
        int memory = 0;
    }
}