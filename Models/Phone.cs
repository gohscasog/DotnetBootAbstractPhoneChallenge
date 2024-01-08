namespace Project.Models
{
    abstract class Phone
    {
        public Phone(string model, string imei, int memory, string number)
        {
            Model = model;
            IMEI = imei;
            Memory = model;
            Number = number;
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

        public string Number
        {
            get => number;
            set => number = value;
        }
        private string Model
        {
            get => model;
            set => model = value;
        }
        private string IMEI
        {
            get => imei;
            set => imei = value;
        }
        private string Memory
        {
            get => memory.ToString();
            set => memory = int.TryParse(value, out int i) ? i : 0;
        }

        string number = string.Empty;
        string model = string.Empty;
        string imei = string.Empty;
        int memory = 0;
    }
}