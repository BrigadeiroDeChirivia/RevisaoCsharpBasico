using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloUm.Aulas
{
    public class AulaUm
    {
        public void TiposBasicos()
        {
            /***
             * ========== AULA 1 ============
             * Tipos básicos de dados em C#
             * (TIPOS NUMÉRICOS INTEIROS)
             * ==============================
            ***/

            sbyte tipoSbyte = 100;      // range de -128 até 127
            short tipoShort = 110;      // range de -32768 até 32767
            int tipoInt = 120;          // range de -2**31 até 2**31-1
            long tipoLong = 130L;       // range de -2**63 até 2**63-1
            
            byte tipoByte = 140;        // range de 0 até 255
            ushort tipoUshort = 150;    // range de 0 até 65535
            uint tipoUint = 160;        // range de 0 até 2**32-1
            ulong tipoUlong = 170;      // range de 0 até 2**64-1
            
            Console.WriteLine($"Tipo sbyte: {tipoSbyte}");
            Console.WriteLine($"Tipo short: {tipoShort}");
            Console.WriteLine($"Tipo int: {tipoInt}");
            Console.WriteLine($"Tipo long: {tipoLong}");
            
            Console.WriteLine($"Tipo byte: {tipoByte}");
            Console.WriteLine($"Tipo ushort: {tipoUshort}");
            Console.WriteLine($"Tipo uint: {tipoUint}");
            Console.WriteLine($"Tipo ulong: {tipoUlong}");
            Console.WriteLine();

            //  OBS: quando o valor estrapola o limite do range ocorre um overflow,
            //  sendo assim, o valor da variável passa a ser o limite oposto.
            //  No exemplo abaixo, ao somar +1 ao valor 255 o resultado vira 0
            byte overflow = 255;
            overflow++;
            Console.WriteLine($"Overflow: {overflow}");
        }
    }
}
