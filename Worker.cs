using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;
namespace hw1
{
    public class Worker: IWorker
    {
      public  string Name {get; set;} 
      public  string Surname {get; set;}
      public  int Salary {get; set;} 

     public Worker()
        {
        Write("Worker info: \n");

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

      }


       public Worker(string name, string surname, int salary)
        {
      Name = name;
      Surname = surname;
      Salary = salary;

      }


      
   

        public void AboutWorker(){
        Write($"Name: {Name}\n");
        Write($"Surname: {Surname}\n");
        Write($"Salary: {Salary}\n");
       }


       public bool BuildBasement(Basement basement){
        if(basement.Installed == false){
         basement.Install();
         basement.Installed = true;
             
        }

  return true;
       }

         public bool BuildWalls(Basement basement, Walls walls){
            if(BuildBasement(basement) == true && walls.Installed == false){

         walls.Install();
         walls.Installed = true;
            
        }
             return true;

       }

           public bool BuildDoor(Basement basement, Walls walls, Door door){
            if(BuildWalls(basement, walls) == true && door.Installed == false){
         door.Install();
         door.Installed = true;
        
            }
   return true;
       }


      public bool BuildWindows(Basement basement, Walls walls, Door door, Window windows){
            if(BuildDoor(basement, walls, door) == true && windows.Installed == false){
      
         windows.Install();
         windows.Installed = true;
            }
          return true;
      }

  public bool BuildRoof(Basement basement, Walls walls, Door door, Window windows, Roof roof){
        if(BuildWindows(basement, walls, door, windows) == true && roof.Installed == false){
         roof.Install();
         roof.Installed = true;
        }
         return true;
      }

       
    }



}