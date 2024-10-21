using System.Collections.Specialized;
using System.Globalization;

Main();

static void Main()

{
    Menu();
    GetMenu();
}
static void Menu()
{
    Console.WriteLine("Main Menu");
    Console.WriteLine("Select an option:");
    Console.WriteLine("1 - encrypt text");
    Console.WriteLine("2 - decrpyt text");
    Console.WriteLine("0 - End");
}
static void GetMenu()
{
    int choice = Convert.ToInt32(Console.ReadLine());
    if (choice == 0)
    {
        Environment.Exit(0);
    }
    if (choice == 1)
    {
        Console.WriteLine("Enter a string:");
        string str = Console.ReadLine();

        Console.WriteLine("Enter no of rotation:");
        int noOfrotation = Convert.ToInt32(Console.ReadLine());


        string encrypt = (Encrypt(str, noOfrotation));
        Console.WriteLine($"The sentence you inputted is :,{str}");
        Console.WriteLine($"the encrypted sentence is now :,{encrypt}");


    }

    if (choice == 2)
    {
        Console.WriteLine("Enter a string:");
        string str = Console.ReadLine();

        Console.WriteLine("Enter no of rotation");
        int noOfrotation = Convert.ToInt32(Console.ReadLine());

        string decrypt = Decrypt(str, noOfrotation);

        Console.WriteLine($"The sentence is,{str}");
        Console.WriteLine($"The decrypted sentence is , {decrypt}");
    }
}
static string Encrypt(string ToEncrpy, int Rotation)
{
    string encodedText = " ";
    foreach (char c in ToEncrpy)
    {
        int encodedChar = c + Rotation;

        encodedText += (char)encodedChar;

    }

    return encodedText;

}
static string Decrypt(string line, int Rotation)
{
    string decdedText = " ";

    foreach (char c in line)
    {
        int decoded = c - Rotation;
        decdedText += (char)decoded;

    }
    return decdedText;
}


