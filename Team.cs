using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hw1
{
    public class Team
    {

       public Worker[] workers;

        public Team(){
       workers =
            [
                new Worker("Иван", "Петров", 1000),
                new Worker("Петр", "Иванов", 1000),
                new Worker("Алексей", "Коновалов", 1000),
                new Worker("Сергей", "Алексеев", 1000),
                new Worker("Дмитрий", "Сергеев", 1000)
            ];
        }



 public void DoWork(House house)
        {
            foreach (var worker in workers)
            {
                // Строим фундамент
                if (!house.Basement.Installed)
                {
                    if (worker.BuildBasement(house.Basement))
                    {
                        Console.WriteLine($"{worker.Name} {worker.Surname} построил фундамент.");
                    }
                }
                
                // Строим стены
                if (house.Basement.Installed && !house.Walls.Installed)
                {
                    
                        if (worker.BuildWalls(house.Basement, house.Walls))
                        {
                            Console.WriteLine($"{worker.Name} {worker.Surname} построил стены.");
                        }
                    
                }

                // Устанавливаем двери
               if (house.Walls.Installed && !house.Door.Installed)
                {
                    if (worker.BuildDoor(house.Basement, house.Walls, house.Door))
                    {
                        Console.WriteLine($"{worker.Name} {worker.Surname} установил дверь.");
                    }
                }

                // Устанавливаем окна
                  if (house.Door.Installed)
                {
                    
                        if (worker.BuildWindows(house.Basement, house.Walls, house.Door, house.Windows))
                        {
                            Console.WriteLine($"{worker.Name} {worker.Surname} установил окна.");
                        }
                    }

                        // Устанавливаем крышу
                if (house.Windows.Installed && !house.Roof.Installed)
                {
                    if (worker.BuildRoof(house.Basement, house.Walls, house.Door, house.Windows, house.Roof))
                    {
                        Console.WriteLine($"{worker.Name} {worker.Surname} установил крышу.");
                    }
                }
                }

            
            }
        }

   
    }
    