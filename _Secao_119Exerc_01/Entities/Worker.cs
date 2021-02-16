using System.Collections.Generic;
using _Secao_09Exerc_01.Entities.Enums;

// C# COMPLETO Programação Orientada a Objetos + Projetos -  aulas  119 a 122 - nélio alves 
namespace _Secao_09Exerc_01.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }

        public Department Department { get; set; } // associação entre classes - composição.

        public List<HourContract> Contracts { get; private set; } = new List<HourContract>(); // lista de contratos por trabalhador.

        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        // metodo add.
        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        // metodo remov.
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        // metodo calculo ganhos.
        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
