using Entity;
using BLL;
internal class Program
{
    private static void Main(string[] args)
    {
        FotografoService servicio = new FotografoService();
        Fotografo fotografo = new Fotografo();
        fotografo.Nombre = "marlon";
        fotografo.Apellido = "buelvas";
        fotografo.Telefono = "651651";
        fotografo.Email = "email";
        fotografo.Especialidad = "ejemplo";
        servicio.AgregarFotografo(fotografo);
    }
}