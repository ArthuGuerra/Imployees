using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace FuncionariosPobres.Models
{
    public class Imployees
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public double Salary { get; private set; }
        public List<Imployees> imployees { get; set; } = new List<Imployees>();

        public Imployees(){}
        public Imployees(string name, int id, double salary)
        {
            Name = name;
            Id = id;
            Salary = salary;
        }
        public void Aumento()
        {
            Console.WriteLine("Enter value increase");
            double porcent = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

             Salary +=  (Salary * porcent) / 100;
             Console.WriteLine($"Salario atualizado:  R${Salary.ToString("F2",CultureInfo.InvariantCulture)}");           
        }
    }
}