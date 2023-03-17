using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExsAbstracaoProfGustavo
{
    internal class Person
    {
        string _name;
        string _cpf;
        string _cep;
        string _street;
        int _number;

        public Person()
        {
            Console.Write("Nome: ");
            this._name = Console.ReadLine();
            Console.Write("CPF: ");
            this._cpf = Console.ReadLine();
            Console.Write("CEP: ");
            this._cep = Console.ReadLine();
            Console.Write("Logradouro: ");
           this._street =  Console.ReadLine();
            Console.Write("Número: ");
            this._number = int.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return $"\nDados atribuídos com sucesso!";
        }
    }
}
