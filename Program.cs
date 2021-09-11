using System;
using System.Collections.Generic;
using System.Text;

namespace Practica1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc = 0;
            do
            {
                
                Console.Write("\n\n\nIngrese el valor del siguiente menu: \n\n1. Mostrar Mensaje\n2. Mas Mensajes\n3. Poligono Regnular\n4. Convertir temperatura.\n5. Cambio Divisa.\n6. Numero Par\n7. Dia de las semana\n8. Area y Perimetro\n9. Potencia de un Numero\n10. Tabla de Multiplicar\n11. Promedio de edades\n12. Salir del sistema\n\nIngrese un valor: ");
                opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                    Console.Clear();
                    ImprimirNombre();
                    Console.ReadKey();
                    Console.Clear();
                    break;

                    case 2:
                    Console.Clear();
                    MostrarMasMensajes();
                    Console.ReadKey();
                    Console.Clear();
                    break;

                    case 3:
                    Console.Clear();
                    PoligonoRegular();
                    Console.ReadKey();
                    Console.Clear();
                    break;

                    case 4:
                    Console.Clear();
                    ConversionTemperatura();
                    Console.ReadKey();
                    Console.Clear();
                    break;

                    case 5:
                    Console.Clear();
                    CambioDivisas();
                    Console.ReadKey();
                    Console.Clear();
                    break;

                    case 6:
                    Console.Clear();
                    NumeroPar();
                    Console.ReadKey();
                    Console.Clear();
                    break;

                    case 7:
                    Console.Clear();
                    DiasSemanas();
                    Console.ReadKey();
                    Console.Clear();
                    break;

                    case 8:
                    Console.Clear();
                    AreayPerimetro();
                    Console.ReadKey();
                    Console.Clear();
                    break;

                    case 9:
                    Console.Clear();
                    PotenciaNumero();
                    Console.ReadKey();
                    Console.Clear();
                    break;

                    case 10:
                    Console.Clear();
                    TablaMultiplicar();
                    Console.ReadKey();
                    Console.Clear();
                    break;

                    case 11:
                    Console.Clear();
                    PromedioEdades();
                    Console.ReadKey();
                    Console.Clear();
                    break;

                    default:
                       Console.Clear(); 
                    break;

                }

            } while (opc != 12);
            
        }

         public static void ImprimirNombre()
         {

             Console.WriteLine("Felix Rayniel Reynoso Ventura");

         }


           public static void MostrarMasMensajes()
           {

               ImprimirNombre();
               Console.WriteLine("Matricula: 2018-0570");
               Console.WriteLine("Direccion: Calle San Antonio, Casi esq. 27 de febrero, Villa Riva, Prov. Duarte");
               Console.WriteLine("Telefono: +1(829)789-6428");
               
           }

            public static void PoligonoRegular()
            {

            }


            public static void ConversionTemperatura(){

                double grados, convercion;

                Console.Write("Ingrese la cantidad de grados que quiere convertir a Fahrenheit: ");
                grados = Convert.ToDouble(Console.ReadLine());
                convercion = ((grados * 1.8) + 32);
                Console.WriteLine("El resultado de la convercion es: {0}", convercion);

            }

            public static void CambioDivisas(){

                    double  dolar, euro, pesos, resultado;
                    int opcion;

                    do{

                        Console.Write("Ingrese el numero de la moneda que quiere cambiar(Ingrese 3 para volver atras) : \n\n 1. Dolar\n 2. Euro\n\n\n\n\n Selecione una opcion:");
                        opcion = Convert.ToInt32(Console.ReadLine());
                        switch (opcion)
                        {
                            case 1:
                                Console.Write("Ingrese el valor del dolar: ");
                                dolar = Convert.ToDouble(Console.ReadLine());
                                Console.Write("Ingrese la cantidad de dolar a convertir: ");
                                pesos = Convert.ToDouble(Console.ReadLine());
                                resultado = (pesos*dolar);
                                Console.WriteLine("Resultado: {0}", resultado +  " pesos");
                            break;

                            case 2:

                                Console.Write("Ingrese el valor del euro: ");
                                euro = Convert.ToDouble(Console.ReadLine());
                                Console.Write("Ingrese la cantidad de euros a convertir: ");
                                pesos = Convert.ToDouble(Console.ReadLine());
                                resultado = (pesos*euro);
                                Console.WriteLine("Resultado: {0}", resultado + " pesos");

                            break;

                        

                            default:
                                CambioDivisas();
                            break;
                        }
                    }while(opcion != 3);

            }

            public static void NumeroPar(){

                int Numero;

                Console.Write("Ingrese el numero para verificar si es par: ");
                Numero = Convert.ToInt32(Console.ReadLine());

                if (Numero % 2 == 0){
                    Console.WriteLine("El numero {0}, es par", Numero);
                }else {
                    Console.WriteLine("El numero {0}, no es par", Numero);
                }

            }

            public static void DiasSemanas(){

                int Numero;

                Console.Write("Ingrese un numero para ver el dia de la semana: ");
                Numero = Convert.ToInt32(Console.ReadLine());

                switch (Numero)
                {
                    case 1:
                    Console.WriteLine("Domingo");
                    break;

                    case 2:
                    Console.WriteLine("Lunes");
                    break;

                    case 3:
                    Console.WriteLine("Martes");
                    break;

                    case 4:
                    Console.WriteLine("Miercoles");
                    break;

                    case 5:
                    Console.WriteLine("Jueves");
                    break;

                    case 6:
                    Console.WriteLine("Viernes");
                    break;

                    case 7:
                    Console.WriteLine("Sabado");
                    break;

                    default:
                    Console.WriteLine("No se acepta un numero nenor que 1 o mayor que 7, intente nuevamente.");
                    Console.ReadKey();
                    Console.Clear();
                    DiasSemanas();
                    break;
                }
            }


            public static void AreayPerimetro(){

                int Opcion, Opcion1;
                double Lado, Base, Altura, Resultado;
                Console.Write("Ingrese el numero del poligono:\n\n1. Cuadrado\n2. Rectangulo\n\nSeleccione una Opcion:  ");
                Opcion = Convert.ToInt32(Console.ReadLine());
                switch (Opcion)
                {
                    case 1:
                        Console.WriteLine("Que deseas calcular del cuadrado? \n\n1. El Area \n2. El Perimetro\n\nSeleccione una Opcion: ");
                        Opcion1 = Convert.ToInt32(Console.ReadLine());
                        if (Opcion1 == 1){
                            Console.Write("Ingrese el valor de cualquier lado del cuadrado: ");
                            Lado = Convert.ToDouble(Console.ReadLine());
                            Resultado = Lado*Lado;
                            Console.WriteLine("El area del cuadrado es igual a {0}", Resultado);
                        }

                        if (Opcion1 == 2){
                            Console.WriteLine("Ingrese el valor de cualquier lado del cuadrado: ");
                            Lado = Convert.ToDouble(Console.ReadLine());
                            Resultado = Lado*4;
                            Console.WriteLine("El perimetro del cuadrado es igual a {0}", Resultado);
                        }
                    break;

                     case 2:
                        Console.Write("Que deseas calcular del cuadrado? \n\n1. El Area \n2. El Perimetro\n\nSeleccione una Opcion: ");
                        Opcion1 = Convert.ToInt32(Console.ReadLine());
                        if (Opcion1 == 1){
                            Console.Write("Ingrese el valor de la base del rectangulo: ");
                            Base = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Ingrese el valor de la altura del rectangulo: ");
                            Altura = Convert.ToDouble(Console.ReadLine());
                            Resultado = Base*Altura;
                            Console.WriteLine("El area del rectangulo es igual a {0}", Resultado);
                        }

                        if (Opcion1 == 2){
                            
                            Console.Write("Ingrese el valor de la base del rectangulo: ");
                            Base = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Ingrese el valor de la altura del rectangulo: ");
                            Altura = Convert.ToDouble(Console.ReadLine());
                            Resultado = (2*Base) + (2*Altura);
                            Console.WriteLine("El Perimetro del rectangulo es igual a {0}", Resultado);
                        }
                    break;
                    
                }
            }

            public static void TablaMultiplicar(){
                Console.Write("Ingrese un valor para visualizar la tabla: ");
                int Numero = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Tabla del {0}", Numero);
                for(int i = 1; i <= 10; i++){
        
                    Console.WriteLine(Numero + "X" + i + " = " + Numero * i);  

                }
            }

            public static void PotenciaNumero(){

                 int Count = 1, Base, Exponente, Resultado = 0; 
                 Console.Write("Ingrese el valor de la base: ");
                 Base = Convert.ToInt32(Console.ReadLine());
                 Console.Write("Ingrese el valor del exponente: ");
                 Exponente = Convert.ToInt32(Console.ReadLine());

                while (Count < Exponente)
                {

                     if (Resultado < Base){
                         Resultado = Base * Base;

                     } else{
                         Resultado = Resultado * Base;
                     }

                     Count ++;
                }

                Console.WriteLine("El Resultado es: {0}", Resultado);
            }

            public static void PromedioEdades(){

                int Edad, CantidadPersonas, Acumulador = 0, Mayor = 0 , Menor = 0, Promedio; 
                Console.Write("Ingrese la cantidad de personas: ");
                CantidadPersonas = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < CantidadPersonas; i++){
                    Console.Write("Ingrese la edad, persona {0}: ", i+1);
                    Edad = Convert.ToInt32(Console.ReadLine());

                    if (Edad > Mayor){
                        Mayor = Edad;
                    }
                    
                    if (Edad < Menor || Menor == 0){
                        Menor = Edad;
                    }

                    Acumulador = Acumulador + Edad;

                }

                Promedio = Acumulador / CantidadPersonas;

                Console.WriteLine("El promedio de edades es: {0}", Promedio);
                Console.WriteLine("La edad mayor es: {0}", Mayor);
                Console.WriteLine("La edad menor es: {0}", Menor);
            }
    }
}
