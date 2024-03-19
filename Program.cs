using System.Globalization;
using FuncionariosPobres.Models;

Console.WriteLine("hello my Beautiful boss. How many imployees do you want gift ?");

int n = int.Parse(Console.ReadLine());

List<Imployees> imployees = new List<Imployees>();

Imployees[] imp = new Imployees[n];

for (int i = 1; i <= imp.Length; i++)
{
    Console.WriteLine($"Imployee {i}");
    Console.WriteLine($"Id: ");
    int id = int.Parse(Console.ReadLine());
    Console.WriteLine($"Name: ");
    string name = Console.ReadLine();
    Console.WriteLine($"Salary: ");
    double salary  = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
    Imployees func = new Imployees(name,id,salary);
    imployees.Add(func);

}

Console.WriteLine("Enter the employee id that will have salary increase: ");
int idList = int.Parse(Console.ReadLine());

Imployees funcionario = imployees.Find(x => x.Id == idList);

if (funcionario != null)
{
    funcionario.Aumento();
}
else
{
    Console.WriteLine("This id don't exist; Try again");
}

for(int i =0; i < imployees.Count; i++)
    {
        Console.WriteLine($"id: {imployees[i].Id}");
        Console.WriteLine($"Name: {imployees[i].Name}");
        Console.WriteLine($"Salary: {imployees[i].Salary.ToString("F2",CultureInfo.InvariantCulture)}");

    }