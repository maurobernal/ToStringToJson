
using System.Text.Json;
int numero = 2;
string cadena = "Cadena";
DateOnly fecha = new DateOnly(2023, 6, 30);

System.Console.WriteLine(numero);
System.Console.WriteLine(cadena);
System.Console.WriteLine(fecha.ToString("ddd, dd/MM/yyyy"));

Alumnos alumno = new() { Id = 2, Nombres = "Mauro", Apellidos = "Bernal" };

System.Console.WriteLine(alumno);
System.Console.WriteLine(alumno.ToString());

System.Console.WriteLine(JsonSerializer.Serialize(alumno));


public class Alumnos
{
    public int Id { get; set; }
    public string Nombres { get; set; } = string.Empty;
    public string Apellidos { get; set; } = string.Empty;

    /*public override string ToString()
    => $"Nombres:{Nombres}, Apellidos:{Apellidos}";*/

    public override string ToString()
 => JsonSerializer.Serialize(this, new JsonSerializerOptions() { WriteIndented = true });
}