using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
/*
transacción aprobada o transacción rechazada
durante el registro debe preguntarle al usuario si es una transacción aprobada o rechazada

buscar numero de transacción sino existe indicarle al user que es invalido y preguntarle si desea realizar otra búsqueda si la respuesta es Si le permitirá ingresar otro numero de transacción en caso de ser No lo enviá al menú principal una vez colocado un numero de transacción existente solo se permite editar el nombre del cliente y el monto de la transacción.

Los dos tipos de transacción se deben poder eliminar pero cuando se elimina una transacción de tipo aprobada, estas transacciones aparte de ser eliminada del listado de su tipo se debe agregar en otro listado para control de auditoria ese otro listado para transacciones aprobada borrada se llama transacciones canceladas , pero al borrar las transacciones rechazadas se deben eliminar de el listado de su tipo y se debe agregar en otro listado llamado transacciones eliminadas. 


 */



namespace tarea_progrmacion
{
	interface IPersona
	{
		int numero_transaccionp();
	}
	public class Persona
	{
		List<Persona> persona = new List<Persona>
		{
				new Persona {
				num_transaccion = 296942394239,
				nombre = "Sergio",
				monto = 0
			},
				new Persona {
				num_transaccion = 220947334037,
				nombre = "Pedro",
				monto = 0
			},
				new Persona {
				num_transaccion = 284857893745,
				nombre = "Cristian",
				monto = 0
			},
				new Persona {
				num_transaccion = 278546789546,
				nombre = "Allyson",
				monto = 0
			}
		};
		public void Mostrar(int num_transaccion_ver)
		{
			foreach (string i in persona) 
			{
				if(num_transaccion_ver = num_transaccion){
					int res;
					int r;
					do
					{
						Console.WriteLine(cliente.nombre + " ¿Qué tipo de transacció deseas realizar?");
						Console.WriteLine("");
						Console.WriteLine("1 = Retiro");
						Console.WriteLine("2 = Deposito");
						Console.WriteLine("3 = Salir");
						Console.WriteLine("");
						res = int.Parse(Console.ReadLine());
						switch (res)
						{
							case 1://
								Console.WriteLine("¿Qué cantidad desea retirar?");
								int cantidad = int.Parse(Console.ReadLine());
								i[2].retiro(cantidad);
								r = 0;
								break;

							case 2:
								Console.WriteLine("¿Qué cantidad desea depositar?");
								cantidad = int.Parse(Console.ReadLine());
								i[2].deposito(cantidad);
								r = 0;
								break;

							case 3:
								Console.WriteLine("Cerrando sesión " +  i[1]);
								Console.WriteLine("Puede retirar su tarjeta");
								Console.WriteLine("....");
								Console.WriteLine("Que tenga un buen día");
								r = 2;
								break;

							default:
								Console.WriteLine("Esta opción no existe");
								r = 0;
								break;
						}

					} while (r < 2);



					public int retiro(int cantidad)
					{
						if (i[2] <= cantidad)
						{
							Console.WriteLine("Transacción invalida. Fondos insuficientes");
							Console.WriteLine("");
							return i[2];
						}
						else
						{
							Console.WriteLine("Se ha retirado la cantidad de: " + cantidad);
							m = i[2] - cantidad;
							Console.WriteLine("Su monto actual es de " + "$" + m);
							Console.WriteLine("");
							return m;
						}
					}
					public int deposito(int cantidad)
					{
						Console.WriteLine("Se ha depositado la cantidad de: " + "$" + cantidad);
						m = i[2] + cantidad;
						Console.WriteLine("Su monto actual es de " + "$" + m);
						Console.WriteLine("");
						return m;
					}
				}
				else{
  					Console.WriteLine("No se encontro");
					  Console.ReadLine();
				}
			}
		}// 
	}
	// Finalmente se pueden listar todas las transaccionesy se debe indicar cuales están aprobada,  rechazada , cancelada o eliminada.
	public class Cliente : Persona, numero_transaccionp
	{
		public static void Main()
		{
			Persona persona_ver = new Persona();
			Console.WriteLine("Menu de transacciones");
			Console.WriteLine("");
			Console.WriteLine("Numero de la transaccion:");
			int numero_transaccion = Console.ReadLine();
			persona_ver.Mostrar(numero_transaccion);
			Console.WriteLine("");
			public int numero_transaccionp(){
				return 0;
			}
		}
	}
}
