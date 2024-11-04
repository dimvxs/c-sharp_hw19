using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;
namespace hw1
{
    public class TeamLeader: IWorker
    {
       public string Name {get; set;} 
       public string Surname {get; set;}
       public string JobTitle {get; set;}
       public int Salary {get; set;} 

       public void DoWork(House house){
        Write($"{JobTitle} do work \n");
       }

         public TeamLeader(){
        Write("Team Leader info: \n");

        WriteLine("Enter name: ");
        string name = ReadLine();
        Name = name;


        WriteLine("Enter surname: ");
        string surname = ReadLine();
        Surname = surname;

        WriteLine("Enter salary: ");
        string s = ReadLine();
        int salary = int.Parse(s);
        Salary = salary;
        
        JobTitle = "Team Leader";

      }

       public void AboutWorker(){
        Write("Name" + Name + "\n");
        Write("Surname" + Surname + "\n");
        Write("Salary" + Salary + "\n");
        Write("Job Title" + JobTitle + "\n");
       }


          public void GenerateReport(House house)
    {
        WriteLine("Отчет о строительстве:");
        WriteLine($"Фундамент установлен: {house.Basement.Installed}");
        WriteLine($"Стены установлены: {house.Walls.Installed}");
        WriteLine($"Дверь установлена: {house.Door.Installed}");
        WriteLine($"Все окна установлены: {house.Windows.Installed}");
        WriteLine($"Крыша установлена: {house.Roof.Installed}");
    }
    }
}