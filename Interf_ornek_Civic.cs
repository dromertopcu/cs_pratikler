public class Civic : IOtomobil
{
    public Marka HangiMarkanınAracı()
    {
        return Marka.Honda;
    }

    public int KacTekerlektenOluşur()
    {
        return 4;
    }

    public Renk StandartRengiNe()
    {
        return Renk.Gri;
    }
}