using System;

namespace HelloWorld
{
    class Program
    { 
        static void Main(string[] args)
        {   
            int dia,mes1;
            Console.WriteLine("Ingrese la fecha");
            String fecha ;
            fecha=Console.ReadLine();
            Console.WriteLine("la Fecha ingresada es: " + fecha);
            if (fecha[2] == '/' &  fecha[7] == '/'){                   // tipo 3
                dia = Int16.Parse(fecha.Substring(0,2));
                mes1 = traemes1(fecha.Substring(3,4));
                if(mes1 == 0 ){
                     Console.WriteLine("Mes Incorecto");
                }
                else
                    calculadias(dia, mes1 );
                }
            else if (fecha[4] == '-' &  fecha[7] == '-'){              // tipo 2
                dia = Int16.Parse(fecha.Substring(8,2));
                mes1 = Int16.Parse(fecha.Substring(5,2));
                verifica(dia, mes1);
                }
            else if (fecha[2] == '/' &  fecha[5] == '/'){               // tipo 1
                dia = Int16.Parse(fecha.Substring(0,2));
                mes1 = Int16.Parse(fecha.Substring(3,2));
                verifica(dia, mes1);                }
            else {
                Console.WriteLine("no corresponde a un formato definido" ); 
                }
            }
            public static void verifica(int dia, int mes1){			// metodo que verifica que el mes este en un rango de  1 a 12 
                if(mes1 <=12 & mes1 >= 1){							// y el dia este entre 1 y 31
                    if( dia <= 31 & dia >=1 ){
                         calculadias(dia, mes1);
                    }
                    else
                        Console.WriteLine("dia incorrecto" );
                 }
                else 
                    Console.WriteLine("mes incorrecto" );
            }
            
             public static int  traemes1(string mes2){ 				//metodo que trae el mes a un formato entero 
              string[]  meses  = { "Mes Erroneo","ener", "febr", "marz","abri","mayo","juni","juli","agos","sept","octu","novi","dici" };
              int aux =0;
               for(int i =0; i<11 ;i++)
               {
                   if( meses[i] == mes2) { 
                        aux = i;
                        i=11;
                    }
               }
               return aux;
             }
            private static void calculadias (int dia, int mes1){	// Metodo que calcula el total de dias trascurridos hasta la fecha que se ingreso
                int totaldias=0;
                int[]  dias  = { 0,31, 59,90,120,151,181,212,243,273,304,334 };
                totaldias =dias[mes1 - 1 ] +dia;
                Console.WriteLine("la cantidad de dias es:  "+ totaldias);
              }
            }
        }