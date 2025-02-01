using Microsoft.AspNetCore.SignalR;
using Models;

public class Clientes {

    public static int nextId = 1;
    public  int Id {get; private set;}
    public string Nombre {get;set;}
    public string Telefono {get;set;}

    public Clientes (string nombre, string telefono)  {

        if(string.IsNullOrWhiteSpace(nombre)){
            throw new ArgumentException("EL nombre no puede estar en blanco");
        }

        Id = nextId++;
        Nombre = nombre;
        Telefono = telefono;  
    }


}
