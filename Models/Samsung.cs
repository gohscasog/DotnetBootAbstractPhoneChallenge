namespace Project.Models
{
    class Samsung : Phone
    {
        public Samsung(string number) : base(number){}

        public override void InstallApp(string app)
        {
            System.Console.WriteLine($"Installing {app}...");
        }
    }
}