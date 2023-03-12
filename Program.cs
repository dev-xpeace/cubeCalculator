// See https://aka.ms/new-console-template for more information
Console.Write("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());



int cubedNumber = cube(num);
Console.WriteLine(cubedNumber);

Console.ReadLine();


static int cube(int num)
{
    int result = (num * num * num);
    return result;
}
