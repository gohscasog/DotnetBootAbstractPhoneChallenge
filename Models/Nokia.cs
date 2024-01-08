namespace Project.Models
{
    class Nokia : Phone
    {
        public Nokia(string model, string imei, int storage, string number) 
            : base(model, imei, storage, number){}
        
        public override void InstallApp(string app)
        {
            System.Console.WriteLine($"Installing {app} no {Model}...");
        }
    }
}