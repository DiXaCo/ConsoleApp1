namespace ConsoleApp1.Models
{
    public class Cliente
{

    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public char Estado { get; set; }

        public Cliente() { }

        public override string ToString()
        {
            return Nombre +"/"+ Apellido + "/" +Direccion+ "/"+ Telefono+"/" + FechaNacimiento + "/" + Estado;
        }

    }
}