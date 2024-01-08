namespace Project.Models
{
    class Nokia : Phone
    {
        public Nokia(string number) : base(number){}
        
        public override void InstallApp(string app)
        {
            System.Console.WriteLine($"Installing {app}...");
        }
    }
}