using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escritura_de_Letras
{
    class Program
    {
        static string[][] letrasDibujo = new string[25][];
        static char[] letras = new char[25];
        static int totalLetras = -1;
        static void Main(string[] args)
        {
            string[] letra = new string[7];
            letra = cargarLetra("D");
            verLetra(letra);
            letra = cargarLetra("N");
            verLetra(letra);
            

            //Para ver como escribir palabras:
            //crearLetras();  //Carga vocabulario
            //pintarPalabra("DONDE ES"); //Pinta una palabra

            Console.WriteLine("fin programa.");
            Console.ReadKey();
        }

        static public string[] cargarLetra(string letraEleccionada)
        {
            string[] letra = new string[7];
            switch (letraEleccionada)
            {
                case "D":
                    letra[0] = "****** ";
                    letra[1] = "*     *";
                    letra[2] = "*     *";
                    letra[3] = "*     *";
                    letra[4] = "*     *";
                    letra[5] = "*     *";
                    letra[6] = "****** ";
                    break;

                case "N":
                    letra[0] = "*     *";
                    letra[1] = "**    *";
                    letra[2] = "* *   *";
                    letra[3] = "*  *  *";
                    letra[4] = "*   * *";
                    letra[5] = "*    **";
                    letra[6] = "*     *";
                    break;
                default:
                    break;
            }
            return letra;

        }
        static public void verLetra(string[] letra)
        {

            for (int fila = 0; fila < 7; fila++)
            {
                for (int columna = 0; columna < 7; columna++)
                {
                    Console.Write(letra[fila][columna]);
                }
                Console.WriteLine();
            }


        }

        static public void crearLetras()
        {
            crearLetra('N', 0);
            totalLetras++;
            crearLetra('D', 1);
            totalLetras++;
            crearLetra(' ', 2);
            totalLetras++;
            crearLetra('O', 3);
            totalLetras++;
            crearLetra('E', 4);
            totalLetras++;
            crearLetra('S', 5);
            totalLetras++;
            crearLetra('T', 6);
            totalLetras++;

        }
        static public void crearLetra(char letraEleccionada, int posicion)
        {
            string[] letra = new string[7];
            switch (letraEleccionada)
            {
                case ' ':
                    letra[0] = "        ";
                    letra[1] = "        ";
                    letra[2] = "        ";
                    letra[3] = "        ";
                    letra[4] = "        ";
                    letra[5] = "        ";
                    letra[6] = "        ";
                    break;
                case 'E':
                    letra[0] = "********";
                    letra[1] = "*       ";
                    letra[2] = "*       ";
                    letra[3] = "******* ";
                    letra[4] = "*       ";
                    letra[5] = "*       ";
                    letra[6] = "********";
                    break;
                case 'O':
                    letra[0] = "********";
                    letra[1] = "*      *";
                    letra[2] = "*      *";
                    letra[3] = "*      *";
                    letra[4] = "*      *";
                    letra[5] = "*      *";
                    letra[6] = "********";
                    break;
                case 'D':
                    letra[0] = "******* ";
                    letra[1] = "*      *";
                    letra[2] = "*      *";
                    letra[3] = "*      *";
                    letra[4] = "*      *";
                    letra[5] = "*      *";
                    letra[6] = "******* ";
                    break;
                case 'N':
                    letra[0] = "*       *";
                    letra[1] = "* *     *";
                    letra[2] = "*  *    *";
                    letra[3] = "*   *   *";
                    letra[4] = "*    *  *";
                    letra[5] = "*     * *";
                    letra[6] = "*       *";
                    break;
                case 'S':
                    letra[0] = "*********";
                    letra[1] = "*        ";
                    letra[2] = "*        ";
                    letra[3] = "*********";
                    letra[4] = "        *";
                    letra[5] = "        *";
                    letra[6] = "*********";
                    break;
                default:
                    break;
            }
            letrasDibujo[posicion] = letra;
            letras[posicion] = letraEleccionada;
        }

        static public void pintarPalabra(string palabra)
        {
            char letra;
            for (int fila = 0; fila < 7; fila++)
            {
                for (int letrapalabra = 0; letrapalabra < palabra.Length; letrapalabra++)
                {
                    letra = palabra[letrapalabra];
                    for (int letraActual = 0; letraActual <= totalLetras; letraActual++)
                    {
                        if (letras[letraActual] == letra)
                        {
                            Console.Write(letrasDibujo[letraActual][fila]);
                            Console.Write(" ");
                        }
                    }

                }
                Console.WriteLine();
            }
        }


    }
}
