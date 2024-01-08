using System.Collections.Generic;
using Project.Models;

class Program()
{
    static void Main()
    {
        Apple iphone = new
        (
            model: "Iphone 15 Pro",
            imei: "69-345678-876543-9",
            memory: 64,
            number: "+55 (11) 9 6969-6969"
        );
        Samsung galaxy = new
        (
            model: "",
            imei: "12-420000-000420-7",
            memory: 128,
            number: "+55 (21) 9 1234-0420"
        );
        Nokia tijolo = new
        (
            model: "",
            imei: "24-000666-002413-8",
            memory: 1,
            number: "+55 (31) 9 6666-2413"
        );

        List<Phone> phones = [iphone, galaxy, tijolo];

        foreach(Phone p in phones)
        {
            System.Console.WriteLine(p.Number);
            p.InstallApp("WhatsApp");
            p.Call("+55 (13) 9 8765-1234");
            p.Answer();
            System.Console.WriteLine();
        }
    }
}