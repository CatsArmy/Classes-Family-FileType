using System;
using System.Xml.Linq;

namespace FileType_Ex2_Page_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input 1 for FileTypeMain");
            Console.WriteLine("input 2 for FamilyMain");
            int selector = int.Parse(Console.ReadLine());
            while (selector != 1 && selector != 2 )
            {
                Console.Clear();
                Console.WriteLine("error input valid option");
                Console.WriteLine("input 1 for FileTypeMain");
                Console.WriteLine("input 2 for FamilyMain");
                selector = int.Parse(Console.ReadLine());
            }
            if (selector == 1)
            {
                FileTypeMain();
            }
            if (selector == 2)
            {
                FamilyMain();
            }
        }
        static void FileTypeMain()
        {
            Console.WriteLine("Enter Type");
            string type = Console.ReadLine();
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Size");
            double size = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter date");
            double date = double.Parse(Console.ReadLine());
            Console.WriteLine("Is the File Open?");
            bool isOpen = bool.Parse(Console.ReadLine());
            Console.WriteLine("The fuck did you put in it?");
            string content = Console.ReadLine();
            FileManger Folder1 = new FileManger(type, name, size, date, isOpen, content);

            Console.WriteLine("Enter Type");
            type = Console.ReadLine();
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter Size");
            size = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter date");
            date = double.Parse(Console.ReadLine());
            Console.WriteLine("Is the File Open?");
            isOpen = bool.Parse(Console.ReadLine());
            Console.WriteLine("The fuck did you put in it?");
            content = Console.ReadLine();
            FileManger Folder2 = new FileManger(type, name, size, date, isOpen, content);

            if (Folder1.IsSameType(Folder2))
            //name crl type same type size = f1 + f2 date=crl isOpen=true content=f1+f2
            {
                FileManger FolderWomboCombo = new FileManger(type, name, size, date, isOpen, content);
                type = Folder1.GetFileType();
                Console.WriteLine("Enter Name");
                name = Console.ReadLine();

                size = Folder1.GetSize() + Folder2.GetSize();
                Console.WriteLine("Enter date");
                date = double.Parse(Console.ReadLine());

                isOpen = true;

                Console.WriteLine($"The fuck did you put in it?{"with a british accent"}");
                content = Folder1.GetContent() + Folder2.GetContent();
            }
            else
            {
                Console.WriteLine("The Files Aren't The Same");
            }
            isOpen = false;
        }
        static void FamilyMain()
        {
            string name; 
            int TeenAge = 12;int AdultAge = 18;
            int NumAdults = 0;
            int NumTeenagers = 0;
            int NumChilds = 0;
            Console.WriteLine("Input Family Name");
            name = Console.ReadLine();
                Console.WriteLine("Input age for each person, 0 to stop");
            for (int age = int.Parse(Console.ReadLine()); age != 0; age = int.Parse(Console.ReadLine()))
            {
                Console.Clear();              
                if (age >= AdultAge)
                {
                    NumAdults++;
                }
                else if (age < TeenAge)
                {
                    NumChilds++;
                }
                else 
                {
                    NumTeenagers++;
                }
                Console.WriteLine("Input age for each person, 0 to stop");
            }
            double income = 0;
            int counter = 1;
            for (int TempNumAdults = NumAdults;
TempNumAdults > 0; TempNumAdults--)
            {
                Console.WriteLine($"Enter the monthly income of adult number: {counter}");
                Console.WriteLine("enter income");
                income += double.Parse(Console.ReadLine());
                counter++;
            }
            Console.WriteLine("input the avarge family income");
            Console.WriteLine("NOTE NOT UR FAMILYS INCOME");
            double famAvg = double.Parse(Console.ReadLine()); ;
            Family family = new Family(name, NumAdults, NumTeenagers, NumChilds, income);
            FamDisplay(name, NumAdults, NumTeenagers, NumChilds);
            Console.WriteLine(family.AvgIncome(famAvg));
            double waterpoints;
            if (family.AvgIncome(famAvg) == "below avarage")
            {
                waterpoints = family.waterpoints() / 0.1 ;
                Console.WriteLine($"Water credit points = {waterpoints}");
                Console.WriteLine("Your water credit points had 10% added as your income avarage is below the avarage");
            }
            else 
            {
                waterpoints = family.waterpoints();
                Console.WriteLine($"Water credit points = {waterpoints}");
            }
        }
        static void FamDisplay(string name, int adults, int teenagers, int child)
        {
            Console.Clear();
            Console.WriteLine($"Family Name {name}");
            Console.WriteLine($"{adults} Adults");
            Console.WriteLine($"{teenagers} Teenagers");
            Console.WriteLine($"{child} Children");
        }
    }
}
