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
            corr_age = Console.ReadLine();
        } while (CheckNum(corr_age, out age_integer));

        DataUser.Age = age_integer;

        //Животные
        DataUser.PetsCount = 0;
        DataUser.HasPets = ChackHasPats();

        if (DataUser.HasPets)
        {
            DataUser.PetsCount = EnterPetCount();
            DataUser.NamePets = EnterPetsName(DataUser.PetsCount);
        }
        else
        {
            DataUser.NamePets = null;
        }
      

        //Цвета
        DataUser.Countcolor = EnterColorCount();
        DataUser.Favcolor = EnterColorName(DataUser.Countcolor);
        
       

        ShowDataUser(DataUser.Name, DataUser.LastName, DataUser.Age, DataUser.HasPets, DataUser.PetsCount, DataUser.NamePets, DataUser.Favcolor);

    }
    //Проверка на наличие животных
    public static bool ChackHasPats()
    {
        Console.Write("У вас есть питомец? ");
        string HasPets = Console.ReadLine();

        if (HasPets == "Да")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    //Кол-во животных
    public static int EnterPetCount()
    {
        string corrcount_pet;
        int pet_integer;
        do
        {
            Console.Write("Введите кол-во ваших питомцев: ");
            corrcount_pet = Console.ReadLine();
        }
        while (CheckNum(corrcount_pet, out pet_integer));

        return Convert.ToInt32(corrcount_pet);
    }

    //Клички животных
    public static string[] EnterPetsName(int count)
    {
        var result = new string[count];
        Console.WriteLine("Введите клички ваших питомцев: ");
        for (int i = 0; i < result.Length; i++)
        {
            Console.Write(i + 1 + ". ");
            result[i] = Console.ReadLine();
        }
        return result;
    }
    //Кол-во цветов
    public static int EnterColorCount()
    {
        string corrcount_color;
        int color_integer;
        do
        {
            Console.Write("Введите кол-во ваших любимых цветов: ");
            corrcount_color = Console.ReadLine();
        }
        while (CheckNum(corrcount_color, out color_integer));

        return Convert.ToInt32(corrcount_color);

    }
    //Названия цветов
    public static string[] EnterColorName(int count)
    {
        var result = new string[count];
        Console.WriteLine("Введите ваши любимые цвета: ");
        for (int i = 0; i < result.Length; i++)
        {
            Console.Write(i + 1 + ". ");
            result[i] = Console.ReadLine();
        }
        return result;
    }

    public static string[] EnterColorName2(int count, string[] mass)
    {
        
        
        for (int i = 0; i < mass.Length; i++)
        {
            Console.Write(i + 1 + ". ");
            mass[i] = Console.ReadLine();
        }
        return mass;
    }

    //Проверка на корректность
    public static bool CheckNum(string number, out int corrNumber)
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
    public static void ShowDataUser(string name, string lastname, int age, bool haspets, int countpets, string[] name_pets, string[] name_color)
    {
        Console.WriteLine("\n\n\n\n\n");
        Console.WriteLine("Ваше ИФ: {0} {1}", name, lastname);
        Console.WriteLine("Вам {0} лет", age);
        if (haspets)
        {
            Console.WriteLine("У вас {0} питомец(ца), их(его) зовут: ", countpets);

            for (int i = 0; i < name_pets.Length; i++)
            {
                Console.Write(i + 1 + ". ");
                Console.WriteLine(name_pets[i]);
            }
        }
        else
        {
            Console.WriteLine("У вас нет домашних животных");
        }
        Console.WriteLine("Ваши любимые цвета: " );

        for (int i = 0; i < name_color.Length; i++)
        {
            Console.Write(i + 1 + ". ");
            Console.WriteLine(name_color[i]);
        }
        

    }
}

//int countpets, string[] name_pets,
// DataUser.PetsCount, DataUser.NamePets,

