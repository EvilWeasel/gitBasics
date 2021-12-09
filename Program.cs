/* 
procedure AvailabilityCheck(Geraetetyp, Entleihbeginn, Entleihdauer)

    geraeteliste = getGeraeteListe(Geraetetyp)

    foreach geraeteId in geraeteliste
        buchungsdaten = getResDat(geraeteId)
        if (buchungsdaten[1] < Entleihbeginn)
            return GeraeteId
        endif
    endfor

    return 0
endprocedure 
*/

public class Program
{
    public static void Main(string[] args)
    {
        var x = AvailabilityCheck(GeraeteTyp.PC, new DateTime(2018, 1, 1), 2);
    }

    public static int AvailabilityCheck(GeraeteTyp geraeteTyp, 
    DateTime entleihbeginn, int entleihdauer)
    {
        var geraeteliste = GetGeraeteListe(geraeteTyp);
        foreach (var geraeteId in geraeteliste)
        {
            var buchungsdaten = GetResDat(geraeteId);
            for (int i = 0; i < buchungsdaten.Length; i++)
            {
                if (buchungsdaten[i].vonDat < entleihbeginn)
                {
                    return geraeteId;
                }   
            }
        }
    }

    private static Buchungsdaten[] GetResDat(object geraeteId)
    {
        throw new NotImplementedException();
    }

    private static List<Geraet> GetGeraeteListe(GeraeteTyp geraeteTyp)
    {
        throw new NotImplementedException();
    }
}
public enum GeraeteTyp
{
    PC,
    Smartphone,
    Tablet
}

public class Geraet
{
    public int GeraeteId { get; set; }
    public GeraeteTyp Geraetetyp { get; set; }
    public int Entleihbeginn { get; set; }
    public int Entleihdauer { get; set; }
    public Buchungsdaten[] Buchungsdaten { get; set; }
}


public class Buchungsdaten
{
    public DateTime vonDat { get; set; }
    public DateTime bisDat { get; set; }
}