using System.Collections.Generic;
using Project.Models;

class Program()
{
    static void Main()
    {
        Apple iphone = new("+55 (11) 9 6969-6969");
        Samsung galaxy = new("+55 (21) 9 1234-0420");
        Nokia tijolo = new("+55 (31) 9 6666-2413");

        List<Phone> phones = [iphone, galaxy, tijolo];

        foreach(Phone p in phones)
        {
            System.Console.WriteLine(p.number);
            p.InstallApp("Whatsapp");
            p.Call("+55 (13) 9 8765-1234");
            p.Answer();
            System.Console.WriteLine();
        }
    }
}