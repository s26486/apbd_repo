namespace Lab2;

 // See https://aka.ms/new-console-template for more information

 class Program
 {
     public static double average(int[] integers)
     {
         return integers.Average();
     }
     
     public static void Main(string[] args)
     {
         int[] array = { 1, 2, 3, 4, 5 };
         double average = Program.average(array);
         Console.WriteLine(average);
         
     }     
 }