using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A888067.Actividad02
{
    class Program
    {
        static void Main(string[] args)


        {
            //A) Ingreso de aeropuertos

            string IngresoAeropuerto = "";
            List<string> ListaAeropuertos = new List<string>();
            string Agregar = "";

            do
            {
                //El usuario ingresa el código de aeropuerto y se lee
                Console.WriteLine("Ingresar código de aeropuerto: ");
                IngresoAeropuerto = Console.ReadLine();
                

                if (String.IsNullOrEmpty(IngresoAeropuerto)) //Se valida que lo ingresado no esté vacío
                {
                    Console.WriteLine("No se ingresó nada. Intentar nuevamente");
                }
                else if ()//se valida que no se ingresan números
                {
                    Console.WriteLine("Los aeropuertos se identifican con un código de 3 letras. Intentar nuevamente");
                }
                else if (IngresoAeropuerto.Length != 3) //Se valida que las letras ingresadas no sean más de 3
                {
                    Console.WriteLine("Los aeropuertos se identifican con un código de 3 letras. Intentar nuevamente");
                }
                else
                {
                    //se agrega a la lista de aeropuertos y se pregunta si se quiere agregar otro aeropuerto

                    ListaAeropuertos.Add(IngresoAeropuerto.ToUpper()); 
                    Console.WriteLine("Se agregó el aeropuerto a la lista. Desea agregar otro aeropuerto? Si/No");
                    Agregar = Console.ReadLine();
                }
            } while (Agregar.ToUpper() == "SI");


            //B) Ingreso de vuelos

            string Origen;
            string Destino;
            string VueloValidado = "";
            string Capacidad;
            int CapacidadValidada = 0;

            Dictionary<string, int> Vuelos = new Dictionary<string, int>();

            do
            {
                //El usuario ingresa el aeropuerto de origen del vuelo y se lee
                Console.WriteLine("Ingresar origen del vuelo: ");
                Origen = Console.ReadLine();


                if (String.IsNullOrEmpty(Origen)) //se validar que lo ingresado no esté vacío
                {
                    Console.WriteLine("No se ingresó nada. Intentar nuevamente");
                }
                else if ()//No se como validar que no se ingresan números
                {
                    Console.WriteLine("El origen se debe identificar con un código de 3 letras. Intentar nuevamente");
                }
                else if (Origen.Length != 3) //se valida que el código ingresado no tenga más de 3 letras
                {
                    Console.WriteLine("Los aeropuertos se identifican con un código de 3 letras. Intentar nuevamente");
                }
                else
                {
                    //Si se ingresó bien el origen, se solicita que se ingrese el destino

                    Console.WriteLine("Ingresar destino del vuelo: ");
                    Destino = Console.ReadLine();

                    //se realizan las mismas validaciones que en el origen
                    if (String.IsNullOrEmpty(Destino))
                    {
                        Console.WriteLine("No se ingresó nada. Intentar nuevamente");
                    }
                    else if ()
                    {
                        Console.WriteLine("El destino se debe identificar con un código de 3 letras. Intentar nuevamente");
                    }
                    else if (Destino.Length != 3)
                    {
                        Console.WriteLine("Los aeropuertos se identifican con un código de 3 letras. Intentar nuevamente");
                    }
                    else
                    {
                        VueloValidado = Origen + "-" + Destino;

                        //Una vez que se ingresaron bien el origen y destino del vuelo, se ingresa la capacidad del mismo

                        Console.WriteLine("Ingresar capacidad del vuelo: ");
                        Capacidad = Console.ReadLine();

                        //se realizan validaciones para ver que no esté vacio lo integrado y que se pueda transformar a número entero
                        if (String.IsNullOrEmpty(Capacidad))
                        {
                            Console.WriteLine("No se ingresó nada. Intentar nuevamente");
                        }
                        else if (!int.TryParse(Capacidad, out CapacidadValidada))
                        {
                            Console.WriteLine("La capacidad se debe identificar con un número entero. Intentar nuevamente");
                        }
                        else
                        {
                            //si se ingresó todo correctamente, se agrega el vuelo con su capacidad y se pregunta si se desea agregar otro vuelo
                            Vuelos.Add(VueloValidado.ToUpper(), CapacidadValidada);
                            Console.WriteLine("Se agregó el vuelo. Desea agregar otro vuelo? Si/No");
                            Agregar = Console.ReadLine();
                        }
                    }
                }

                Console.WriteLine("Se ingresó el vuelo " + VueloValidado + " con capacidad de " + CapacidadValidada + " personas");
            } while (Agregar.ToUpper() == "SI");



            //C) Ingreso de reservas

            string IDReserva;
            int IDReservaValidado;
            string OrigenReserva;
            string DestinoReserva;
            string VueloReserva;
            string Adultos;
            int CantAdultos;
            string Menores;
            int CantMenores;
            string Infantes;
            int CantInfantes;
            int TotalPasajeros;

            Dictionary<int, string> Reservas = new Dictionary<int, string>();

            do
            {
                //Ingresar y validar ID de reserva
                Console.WriteLine("Ingresar ID de reserva: ");
                IDReserva = Console.ReadLine();


                if (String.IsNullOrEmpty(IDReserva))
                {
                    Console.WriteLine("No se ingresó nada. Intentar nuevamente");
                }
                else if (!int.TryParse(IDReserva, out IDReservaValidado))
                {
                    Console.WriteLine("La reserva se debe identificar con un número entero. Intentar nuevamente");
                }
                else
                {
                    //Ingresar y validar origen

                    Console.WriteLine("Ingresar origen del vuelo: ");
                    OrigenReserva = Console.ReadLine();

                    if (String.IsNullOrEmpty(OrigenReserva))
                    {
                        Console.WriteLine("No se ingresó nada. Intentar nuevamente");
                    }
                    else if ()//validar que no se ingresan números
                    {
                        Console.WriteLine("El destino se debe identificar con un código de 3 letras. Intentar nuevamente");
                    }
                    else if (OrigenReserva.Length != 3)
                    {
                        Console.WriteLine("El origen con un código de 3 letras. Intentar nuevamente");
                    }
                    else
                    {
                        //Ingresar y validar destino

                        Console.WriteLine("Ingresar origen del vuelo: ");
                        DestinoReserva = Console.ReadLine();

                        if (String.IsNullOrEmpty(DestinoReserva))
                        {
                            Console.WriteLine("No se ingresó nada. Intentar nuevamente");
                        }
                        else if ()//validar que no se ingresan números
                        {
                            Console.WriteLine("El destino se debe identificar con un código de 3 letras. Intentar nuevamente");
                        }
                        else if (DestinoReserva.Length != 3)
                        {
                            Console.WriteLine("El destino se identifican con un código de 3 letras. Intentar nuevamente");
                        }
                        else
                        {
                            VueloReserva = OrigenReserva.ToUpper() + "-" + DestinoReserva.ToUpper();

                            //Ingresar y validar adultos

                            Console.WriteLine("Ingresar adultos pasajeros del vuelo: ");
                            Adultos = Console.ReadLine();

                            if (String.IsNullOrEmpty(Adultos))
                            {
                                Console.WriteLine("No se ingresó nada. Intentar nuevamente");
                            }
                            else if (!int.TryParse(Adultos, out CantAdultos))
                            {
                                Console.WriteLine("La capacidad se debe identificar con un número entero. Intentar nuevamente");
                            }
                            else
                            {
                                //Ingresar y validar menores

                                Console.WriteLine("Ingresar menores pasajeros del vuelo (entre 3 y 10 años): ");
                                Menores = Console.ReadLine();

                                if (String.IsNullOrEmpty(Menores))
                                {
                                    Console.WriteLine("No se ingresó nada. Intentar nuevamente");
                                }
                                else if (!int.TryParse(Menores, out CantMenores))
                                {
                                    Console.WriteLine("La capacidad se debe identificar con un número entero. Intentar nuevamente");
                                }
                                else
                                {
                                    //Ingresar y validar infantes

                                    Console.WriteLine("Ingresar menores pasajeros del vuelo (menores de 3 años): ");
                                    Infantes = Console.ReadLine();

                                    if (String.IsNullOrEmpty(Infantes))
                                    {
                                        Console.WriteLine("No se ingresó nada. Intentar nuevamente");
                                    }
                                    else if (!int.TryParse(Infantes, out CantInfantes))
                                    {
                                        Console.WriteLine("La capacidad se debe identificar con un número entero. Intentar nuevamente");
                                    }
                                    else
                                    {
                                        TotalPasajeros = CantAdultos + CantMenores + CantInfantes;

                                        //se valida que no se pueda ingresar una reserva si excede la capacidad disponible del vuelo
                                        if (TotalPasajeros > CapacidadValidada)
                                        {
                                            Console.WriteLine("No se puede tomar la reserva ya que excede la capacidad de pasajeros disponibles");
                                        }
                                        else
                                        {
                                            CapacidadValidada -= TotalPasajeros;

                                            Reservas.Add(IDReservaValidado, VueloReserva);
                                            Console.WriteLine("Se agregó la reserva. Desea agregar otra reserva? Si/No");
                                            Agregar = Console.ReadLine();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            } while (Agregar.ToUpper() == "SI");

            Console.ReadLine();
        }
    }
}
