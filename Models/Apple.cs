namespace Project.Models
{
    class Apple : Phone
    {
        public Apple(string number) : base(number){}

        public override void InstallApp(string app)
        {
            System.Console.WriteLine($"Installing {app}...");
        }
    }
}