using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hw1
{
    public class House
    {

    public Basement Basement { get; set; } = new Basement();
    public Walls Walls { get; set; } = new Walls();
    public Door Door { get; set; } = new Door();
    public Window Windows { get; set; } = new Window(); 
    public Roof Roof { get; set; } = new Roof();

    public bool IsComplete()
    {
        return Basement.Installed && Walls.Installed && Door.Installed && 
               Windows.Installed && Roof.Installed;
    }


     public House()
    {
        

        Basement = new Basement();
        Windows = new Window();
        Walls = new Walls();
        Door = new Door();
        Roof = new Roof();
    }


    public void DrawHouse()
    {
        // Рисуем крышу
        Console.WriteLine("     /\\     ");
        Console.WriteLine("    /  \\    ");
        Console.WriteLine("   /____\\   ");

        // Рисуем стены и двери
        Console.WriteLine("  |      |  ");
        
        // Если дверь установлена, рисуем ее
        Console.Write("  | ");
        Console.Write(Door.Installed ? "[] " : "  "); // Символ двери
        Console.WriteLine("|  ");

        // Рисуем окна
        Console.Write("  | ");
        for (int i = 0; i < 4; i++)
        {
            Console.Write("[] "); // Символы окон
        }
        Console.WriteLine("|  ");

        Console.WriteLine("  |______|  "); // Нижняя часть стен (фундамент)
        
        // Рисуем фундамент
        Console.WriteLine("   |____|   "); // Фундамент
    }

    }


    
}