using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Adopet.Console.Comandoos
{
    internal interface IComando
    {
        Task ExecutarAsync(string[] args);

    }
}
