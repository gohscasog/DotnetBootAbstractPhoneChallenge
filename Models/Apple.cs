namespace Project.Models
{
    class Apple : Phone
    {
        public Apple(string model, string imei, int memory, string number) 
            : base(model, imei, memory, number){}

        public override void InstallApp(string app)
        {
            System.Console.WriteLine($"Installing {app}...");
        }
    }
}