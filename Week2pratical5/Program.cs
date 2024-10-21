using System.Collections.Specialized;
using System.Globalization;
using System.Text;

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
    try
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

    catch (Exception ex)
    {
        Console.WriteLine($"Error. {ex.Message}");
    }
}
static string Encrypt(string ToEncrpy, int Rotation)
{
    string encodedText = " ";
    foreach (char c in ToEncrpy)

    {
        if (!char.IsLetter(c))
        {
            encodedText += c;
        }
        else
        {
            int encodedChar = c + Rotation;

            if (char.IsLower(c))
            {
                if (encodedChar > 'z')
                {
                    encodedChar -= 26;

                }

                else if (char.IsUpper(c))
                {
                    if (encodedChar > 'Z')
                    {
                        encodedChar -= 26;
                    }
                }
            }

            encodedText += (char)encodedChar;

        }
    }

    return encodedText;

}
static string Decrypt(string line, int Rotation)
{
    string decodedText = " ";

    foreach (char c in line)

    {
        if (!char.IsLetter(c))
        {
            decodedText += c;
        }
        else { 
            int decodedChar = c - Rotation;
            if (char.IsLower(c))
            {


                if (decodedChar < 'a')  
                {
                    decodedChar += 26;
                }
            else if (char.IsUpper(c))
                {
                    if (decodedChar < 'A')
                    {
                        decodedChar += 26;
                    }
                }
            }
            decodedText += (char)decodedChar;
        }
       
        

    }
    return decodedText;
}


