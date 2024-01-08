namespace Project.Models
{
    abstract class Phone
    {
        public Phone(string model, string imei, int storage, string number)
        {
            Model = model;
            IMEI = imei;
            Storage = storage;
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
        protected string Model
        {
            get => model;
            set => model = value;
        }
        protected string IMEI
        {
            get => imei;
            set => imei = value;
        }
        protected int Storage
        {
            get => storage;
            set => storage = value;
        }

        string number = string.Empty;
        string model = string.Empty;
        string imei = string.Empty;
        int storage = 0;
    }
}