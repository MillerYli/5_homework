using System;
using System.Globalization;
using System.Runtime.CompilerServices;

class Program
{
    public static void Main(string[] args)
    {
        (string Name, string LastName, int Age, bool HasPets, int PetsCount, string[] NamePets, string[] Favcolor, int Countcolor) DataUser;
        Console.Write("Введите ваше имя: ");
        DataUser.Name = Console.ReadLine();
        Console.Write("Введите вашу фамилию: ");
        DataUser.LastName = Console.ReadLine();
       
        //Возраст
        string corr_age;
        int age_integer;
        do
        {
            Console.Write("Введите возраст цифрами: ");
            corr_age= Console.ReadLine();
        }while (CheckNum(corr_age, out age_integer));

        DataUser.Age = age_integer;
        Console.Write("У вас есть питомец? ");
        //Животные
        string answer_pet = Console.ReadLine();
        if (answer_pet == "Да")
        {
            DataUser.HasPets = true;
            string corrcount_pet;
            int pet_integer;
            do
            {
                Console.Write("Введите кол-во ваших питомцев: ");
                corrcount_pet= Console.ReadLine();
            }
            while(CheckNum(corrcount_pet,out pet_integer));

            DataUser.PetsCount = pet_integer;
            NickNamePats(pet_integer);
        }
        else
        {
            DataUser.HasPets = false;
        }
        //Цвета
        Console.WriteLine();
        string corrcount_color;
        int color_integer;
        do
        {
            Console.Write("Введите кол-во ваших любимых цветов: ");
            corrcount_color= Console.ReadLine();
        }
        while(CheckNum(corrcount_color,out color_integer));

        DataUser.Countcolor = color_integer;
       
        NameColors(color_integer);

       // DataOutput(DataUser.Name, DataUser.LastName, DataUser.Age,  DataUser.NamePets, DataUser.Favcolor);
        
        Console.WriteLine(DataUser);
        
    }
    //Цвета метод
    static string[] NameColors(int count)
    {
        Console.WriteLine("Введите ваши любимые цвета: ");
        var result = new string[count];
        for (int i = 0; i < result.Length; i++)
        {
            Console.Write(i + 1 + ": ");
            result[i] = Console.ReadLine();
        }
        Console.WriteLine("Ваши любимые цвета: ");
        foreach (var color in result)
        {
            Console.Write(color + ", ");
        }

        return result;
    }


    //Животные метод
    static string[] NickNamePats(int count)
    {

        Console.WriteLine("Введите клички ваших питомцев: ");
        var result = new string[count];
        for (int i = 0; i < result.Length; i++)
        {
            Console.Write(i + 1 + ": ");
            result[i] = Console.ReadLine();
        }
        Console.WriteLine("Клички ваших питомцев: ");
        foreach (var pets_nik in result)
        {
            Console.Write(pets_nik + ", ");
        }
        return result;
    }
//Проверка на корректность
    static bool CheckNum(string number, out int corrNumber)
    {
        if (int.TryParse(number, out int intNum))
        {
            if (intNum > 0)
            {
                corrNumber = intNum;
                return false;
            }
        }
        {
            Console.WriteLine("Возможно данные введены не корректно, пожалуйста, повторите попытку снова. ");
            corrNumber = 0;
            return true;
            CheckNum(number, out corrNumber);
        }
        
    }
    static void DataOutput(string name, string lastname, int age,  string[] namepets, string[] favcolor)
    {
        Console.WriteLine("Ваше имя и фамилия: {0} {1}", name,  lastname);
        Console.WriteLine("Вам {0} лет", age);
        Console.WriteLine("Ваши питомцы это: ");

        foreach(var pet in namepets)
        {
            Console.WriteLine(pet + " ");
        }
        Console.WriteLine("Ваши любимые цвета: ");
        foreach(var color in favcolor)
        {
            Console.WriteLine(color + " ");
        }
     
    }
}
