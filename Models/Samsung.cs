namespace Project.Models
{
    class Samsung : Phone
    {
        public Samsung(string model, string imei, int memory, string number) 
            : base(model, imei, memory, number){}

        public override void InstallApp(string app)
        {
            System.Console.WriteLine($"Installing {app}...");
        }
    }
}