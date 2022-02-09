using System;

namespace P127Task
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Task 1
            //string name = "Teyyare";

            //bool find = false;

            //char search = Convert.ToChar(Console.ReadLine());


            //for (int i = 0; i < name.Length; i++)
            //{
            //    if(name[i] == search)
            //    {
            //        find = true;
            //    }
            //}


            //if (find)
            //{
            //    Console.WriteLine(search + " herfi tapildi");
            //}
            //else
            //{
            //    Console.WriteLine(search + " herfi contex-de yoxdur");
            //}
            #endregion

            #region Task 2
            //int num = Convert.ToInt32(Console.ReadLine());
            //if (num == 0)
            //{
            //    Console.WriteLine("eded neytraldir");
            //}
            //else if (num % 2 == 0)
            //{
            //    Console.WriteLine("eded cutdur");
            //}
            //else
            //{
            //    Console.WriteLine("eded tekdir");
            //}

            #endregion

            #region Task 3
            //int num = Convert.ToInt32(Console.ReadLine());
            //int count = 1;

            //if(num <= 50)
            //{
            //    for (int i = 4; i <=num ; i++)
            //    {
            //        if(i%3 == 0)
            //        {
            //            count++;
            //        }
            //    }
            //}else if(num > 50 && num <= 100)
            //{
            //    for (int i = 6; i <= num; i++)
            //    {
            //        if(i%5 == 0)
            //        {
            //            count++;
            //        }
            //    }
            //}
            //else
            //{
            //    for (int i = 9; i <= num; i++)
            //    {
            //        if (i % 8 == 0)
            //        {
            //            count++;
            //        }
            //    }
            //}
            //Console.WriteLine(count);
            #endregion


            //int num = Convert.ToInt32(Console.ReadLine());

            //switch (num)
            //{
            //    case 50:
            //        Console.WriteLine(num);
            //        break;
            //    case 55:
            //        Console.WriteLine(num);
            //        break;
            //    default:
            //        Console.WriteLine("Bele bir case yoxdur");
            //        break;
            //}

            //if(num == 50)
            //{
            //    Console.WriteLine(num);
            //}else if(num == 55)
            //{
            //    Console.WriteLine(num);
            //}
            //else
            //{
            //    Console.WriteLine("Bele bir case yoxdur");
            //}

            //switch (num)
            //{
            //    case 50:
            //    case 40:
            //    case 60:
            //        Console.WriteLine("Her sey yazila biler");
            //        break;
            //    case 100:
            //        Console.WriteLine("Zehmet olmasa kicik eded daxil edin");
            //        break;
            //    default:
            //        break;
            //}

            int[] numbers = {1,6,15,29,30};

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            //int[] arr = new int[5] { 1,2,3,4,5};
            //foreach (int num in arr)
            //{
            //    Console.WriteLine(num);
            //}

            string[] students = { "Avaz", "Oruc", "Isa", "Lutfiyar","Camal" };
            string[] newArr = new string[2];
            int index = 0;

            //newArr[0] = "Okay";
            //newArr[1] = "Test";
            //foreach (var item in newArr)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (string student in students)
            //{
            //    foreach (char letter in student)
            //    {
            //        if (letter == 'c' || letter == 'C')
            //        {
            //            newArr[index] = student;
            //            index++;
            //        }
            //    }
            //}

            //foreach (string studentWitchCLetter in newArr)
            //{
            //    Console.WriteLine(studentWitchCLetter);
            //}

            //int price = 20;
            //int total = 0;
            //while (total <= 100)
            //{
            //    total += price;
            //}

            //Console.WriteLine(total);
        }

    }
}
