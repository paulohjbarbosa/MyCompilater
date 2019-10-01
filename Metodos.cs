using System.Linq;

public class Metodos
{
    public static ReservedWorks reservedWorks = new ReservedWorks();

    private string[] keywords = reservedWorks.KeyWords;
    public bool IsReservedWorks(string s)
    {
        try
        {
            return keywords.Contains(s);
        }
        catch (System.Exception ex)
        {

            throw new System.Exception(ex.Message);
        }
    }
}