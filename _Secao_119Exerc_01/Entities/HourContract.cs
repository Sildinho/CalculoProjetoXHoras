using System;

// C# COMPLETO Programação Orientada a Objetos + Projetos -  aulas  119 a 122 - nélio alves 
namespace _Secao_09Exerc_01.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; } // data do contrato
        public double ValuePerHour { get; set; } // valor por hora
        public int Hours { get; set; } // horas - duração

        public HourContract()
        {
        }

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        // metodo calculo horas
        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }
    }
}