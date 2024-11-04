// See https://aka.ms/new-console-template for more information
using hw1;

class Program
{
    static void Main(string[] args)
    {
        House house = new House(); // Создаём новый дом
        Team team = new Team(); // Создаём новую команду строителей
        TeamLeader leader = new TeamLeader(); // Создаём бригадира

        // Строим дом
        team.DoWork(house);

        // Генерируем отчет о строительстве
        leader.GenerateReport(house);

        // Рисуем дом
        house.DrawHouse();
    }
}