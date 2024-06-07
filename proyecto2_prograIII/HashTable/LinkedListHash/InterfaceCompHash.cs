using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto2_prograIII.HashTable.LinkedListHash
{
    public interface InterfaceCompHash
    {


        bool igualQueHash(Object q);
        bool igualQueEliminarHash(Object q);

        /// <summary>
        /// TOMA DETERMINADO VALOR (STRING) Y LO DEBE DEVOLVER EN FORMA DE LA SUMA DE SUS CARACTERES EN CODIGO ASCII
        /// 
        ///
        /// 
        ///    long asciiSum = 0;
        ///    foreach (char c in stringATransformar)
        ///    {
        ///        asciiSum += (int)c; // Sumar el valor ASCII del carácter
        ///    }
        ///    return asciiSum;
        /// 
        /// 
        /// 
        /// </summary>
        /// <returns></returns>
        long convertirASCII();

    }
}
