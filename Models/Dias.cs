public static class Dias{
    public static List<string> ListaDias {get; private set;}=new List<string> {"Lunes ", "Martes ", "Miercoles ", "Jueves ", "Viernes ", "Sabado ", "Domingo "}; 
    public static List<string> ListaCamperas {get; private set;}=new List<string> {"campera1.jpg", "campera2.jpg", "campera3.jpg", "campera4.jpg", "campera5.jpg"};
    public static List<string> ListaTops {get; private set;}=new List<string> {"top1.jpg", "top2.jpg", "top3.jpg", "top4.jpg", "top5.jpg"};
    public static List<string> ListaRemeras {get; private set;}=new List<string> {"remera1.jpg", "remera2.jpg", "remera3.jpg", "remera4.jpg", "remera5.jpg"};
    public static List<string> ListaCalzas {get; private set;}=new List<string> {"calza1.jpg", "calza2.jpg", "calza3.jpg", "calza4.jpg", "calza5.jpg"}; 
    public static List<string> ListaZapas {get; private set;}=new List<string> {"zapas1.jpg", "zapas2.jpg", "zapas3.jpg", "zapas4.jpg", "zapas5.jpg"};
    public static Dictionary<string, Indumentaria> DicDias {get; private set;}=new Dictionary<string, Indumentaria>();

    static Dias(){}
    public static Dictionary<string, Indumentaria> IngresarIndumentaria(string DiaSeleccionado, Indumentaria item){
        DicDias.Add(DiaSeleccionado, item);
        return DicDias;
    }
}