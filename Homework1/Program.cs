using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

AgentSecurity();
List<Guest> Guests = LoadGuest();
Console.WriteLine("Please Choose one of the Following " +
"\n 1)Display Guest." +
"\n 2)Add guests to the list." +
"\n 3)Update guests responses." +
"\n 4)How many guests are definitely attending." +
"\n 5)How mant guest could potentially attend." +
"\n 6)How many vegetarian vs non-vegetarians are attending." +
"\n 7)Add Guest into Suspicous List");

int querychoice = Convert.ToInt32(Console.ReadLine());


switch (querychoice)
{
    case 1:
        ViewGuestList();
        break;
    case 2:

        AddGuest();

        break;
    case 3:
        FindUser();
        break;

    case 4:
           ComfirmedGuest();
        break;

    case 5:

        potentiallyComing();

        break;

    case 6:
        lifeChoiceCalculator();
        break;

    case 7:
        SuspeciousGuest();
        break;

    default:
        Console.WriteLine("Sorry this Choice isnt available");
        break;
}

List<Guest> LoadGuest()
{
    List<Guest> Data = new List<Guest>();

    Data.Add(new Guest("James", "Vegetarian", "yes"));
    Data.Add(new Guest("Alex", "Non Vegetarian", "no"));
    Data.Add(new Guest("WarLord Mim", "Non Vegetarian", "yes"));
    Data.Add(new Guest("Jamie", "Non Vegetarian", "no"));
    Data.Add(new Guest("Emma", "Non Vegetarian", "yes"));
    Data.Add(new Guest("Stwert", "Non Vegetarian", "maybe"));
    Data.Add(new Guest("Mim", "Non Vegetarian", "yes"));
    Data.Add(new Guest("Mr Whiskers", "Non Vegetarian", "maybe"));
    Data.Add(new Guest("Ben", "Non Vegetarian", "yes"));
    Data.Add(new Guest("Dover", "Non Vegetarian", "maybe"));

    return Data;
}

void ViewGuestList()
{
    Console.WriteLine("Guest List");
    foreach (Guest g in Guests)
    {
        Console.WriteLine("Name:" + " " + g.name + " " + g.lifechoice + "| " + "Attending?" + "| " + g.rsvp);

    }
}
void FindUser()
{
    Console.WriteLine("Which user would you like to find");
    string find = Console.ReadLine();
    bool foundname = Guests.Any(i => i.name == find);



    if (foundname == true)
    {
        Guest N = Guests.Find(x => x.name == find);
        Console.WriteLine(N.name + N.rsvp);
        Console.WriteLine("Input new response");
        string newentry = Console.ReadLine();
        N.rsvp = newentry;

    }
    else
    {
        Console.WriteLine("sorry this person doesnt exist");

    }
}


void ComfirmedGuest()
{
    int confirmed = Guests.Count(p => p.rsvp == "yes");
    Console.WriteLine("The Comfirmed Amount of Guest that are coming are" + " " + confirmed);

}

void AddGuest()
{
    Console.WriteLine("Please entre new Guest; Name, LifeChoice and then RSVP");
    string Name = Console.ReadLine();
    string lifechoice = Console.ReadLine();
    string rsvp = Console.ReadLine();
    Guest N = new Guest(Name, lifechoice, rsvp);
    Guests.Add(N);
}


void potentiallyComing()
{
    int likelyattending = Guests.Count(p => p.rsvp == "maybe");
    int attendees = Guests.Count(p => p.rsvp == "yes");
    Console.WriteLine("The amount of Guest that could Potentially come are" + " " + attendees + likelyattending);

}

void lifeChoiceCalculator()
{
    int Vegaterians = Guests.Count(p => p.lifechoice == "Vegetarian");
    int NonVegaterians = Guests.Count(p => p.lifechoice == "Non Vegetarian");
    Console.WriteLine("The amount of Vegatrians =" + Vegaterians);
    Console.WriteLine("The amount of Non Vegatrians =" + NonVegaterians);
}

void SuspeciousGuest()
{

    foreach (Guest g in Guests)
    {
        Console.WriteLine("Name:" + " " + g.name + " " + g.lifechoice + "| " + "Attending?" + "| " + g.rsvp);

    }
    List<string> SuspeciousList = new List<string>();
    Console.WriteLine("Here Are the Guest attending. Any Suspecious Guests? Please entre Name");
    string input = Console.ReadLine();
    SuspeciousList.Add(input);
    Console.WriteLine("Hmmmm We've Also Had Our Eye on" + input);

}


void AgentSecurity()
{
    Console.WriteLine("Hello And Welcome to Sheffield Hallam James Bond Premiere ");
    Thread.Sleep(1000);
    Console.WriteLine("Loading Secret Agent 007 lOGIN Prfile…█▒▒▒▒▒▒▒▒▒");
    Thread.Sleep(1000);
    Console.WriteLine("To Comfirm Agent identity Please Log login");
    Console.WriteLine("Please Entre UserName and Password *case sensative");
    String Username = Console.ReadLine();
    string password = Console.ReadLine();

    if (Username == "Bond" && password == "007")
    {
        Console.Clear();
        Console.WriteLine("Welcome 007");
        Console.Title = "ASCII Art";
        string title = @"
     0000             0000        7777777777777777/========___________
       00000000         00000000      7777^^^^^^^7777/ || ||   ___________
      000    000       000    000     777       7777/=========//
     000      000     000      000             7777// ((     //
    0000      0000   0000      0000           7777//   \\   //
    0000      0000   0000      0000          7777//========//
    0000      0000   0000      0000         7777
    0000      0000   0000      0000        7777
     000      000     000      000        7777
      000    000       000    000       77777
       00000000         00000000       7777777
         0000             0000        777777777
                                                                     ";

        Console.WriteLine(title);
        Thread.Sleep(2000);
        Console.WriteLine("We've Created this program for your saftey");
        Thread.Sleep(2000);
        Console.WriteLine("Pease Look at the Guest list before attending Event");
        Thread.Sleep(2500);
        Console.WriteLine("Crimal WarLoad Mim Will be there Your mession is to capture and secure package");
        Console.WriteLine("Good Luck");


        Thread.Sleep(3500);
        Console.Clear();
    }

    else

    {
        Console.WriteLine("UNAUTHORIZED ACCESS - TERMINATING PROGRAM!");
        Environment.Exit(0);
    }

}
