using System.Diagnostics;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите количество цифр:");
        int count = int.Parse(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            Process.Start("notepad.exe");
        }
        Console.ReadLine();
        Kill();
    }
    static void Kill()
    {
        Process[] notepads = Process.GetProcessesByName("notepad");

        foreach (Process notepad in notepads)
        {
            notepad.Kill();
        }
        Console.WriteLine("Все процессы Notepad были завершены.");
    }
}