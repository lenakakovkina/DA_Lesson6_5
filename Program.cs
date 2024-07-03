string guestname = "default";
int kidsnumber = 0;
int adultnumber = 0;
int oldtnumber = 0;
int allguests = 0;
while (guestname != "stop")
{
    Console.WriteLine("What is your name? In case there is no more guests print stop");
    guestname = Console.ReadLine();


    if (guestname != "stop")
    {
        Console.WriteLine("What is your full age?");
        string guestageraw = Console.ReadLine();
        int.TryParse(guestageraw, out int guestage);

        if (guestage > 0 && guestage < 18)
        {
            Console.WriteLine($"Hi {guestname}! Go to room for kids");
            kidsnumber += 1;
        }
        else if (guestage >= 18 && guestage < 50)
        {
            Console.WriteLine($"Hi {guestname}! Go to room for adults");
            adultnumber += 1;
        }
        else if (guestage > 50 && guestage < 120)
        {
            Console.WriteLine($"Hi {guestname}! Go to room for old people");
            oldtnumber += 1;
        }
        else
        {
            Console.WriteLine("Input error! Try one more time!");
            continue;
        }
    }
    else if (guestname == "stop")
    {
        allguests = kidsnumber + adultnumber + oldtnumber;
        Console.WriteLine($"All are in place.\n We have {allguests} guest(s).\n In kid's room we have {kidsnumber} people.\n " +
            $"In room for adults we have {adultnumber} people.\n In room old people we have {oldtnumber} people.\n");
        break;
    }
}
