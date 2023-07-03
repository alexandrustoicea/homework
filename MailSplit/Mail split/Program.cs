using System;
using System.ComponentModel;

public static class Program
{
    public static void Main()
    {
        ObfuscateEmail();
    }

    public static void ObfuscateEmail()
    {
        //Asking for the email address and introducing it into a string
        Console.WriteLine("Please enter your email adress: ");
        string email = Console.ReadLine();

        //Creating empty strings to separate the username from the domain and also finding the email length
        string censoredEmail = string.Empty;
        string domain = string.Empty;
        int emailLength = email.Length;
        int[] array = new int[emailLength];

        //Verifying if the email address contains '@' to determin if it's valid or not
        if (email.Contains("@"))
        {
            //This is taking every letter from the email and checks if it's '@' or not so that it can separate the username from the domain
            for (int i = 0; i < emailLength; i++)
            {
                array[i] = email[i];
                if (array[i] == '@')
                {
                    //It's taking every letter from the '@' sign to the first letter from the email and it's replacing it with '*'
                    for (int j = i; j > 0; j--)
                    {
                        censoredEmail = censoredEmail + '*';
                    }
                }
            }

            //This does the same as the previous for statement, but it wants to get only the domain this time
            for (int index = 0; index < emailLength; index++)
            {
                array[index] = email[index];
                if (array[index] == '@')
                    for (int s = index; s < emailLength; s++)
                    {
                        domain = domain + email[s];
                    }
            }
        }
        else Console.WriteLine("This is not a valid email adress.");

        //Prints the censored username + the not censored domain
        Console.WriteLine(censoredEmail + domain);
    }
}