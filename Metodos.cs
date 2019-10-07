using System;
using System.Collections.Generic;
using System.Linq;

public class Metodos
{
    public static ReservedWorks reservedWorks = new ReservedWorks();
    public static Operations keyoperations = new Operations();

    private string[] keywords = reservedWorks.KeyWords;
    private string[] keyoperator = keyoperations.KeyOperations;
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
    public bool IsOperation(string s)
    {
        try
        {
            return keyoperator.Contains(s);
        }
        catch (System.Exception ex)
        {

            throw new System.Exception(ex.Message);
        }
    }

    public bool IsNumeric(string s)
    {
        try
        {
            bool verification = int.TryParse(s, out int n);
            return verification;
        }
        catch (System.Exception ex)
        {

            throw new System.Exception(ex.Message);
        }
    }

    public bool InitialNumber(string s)
    {
        try
        {
            char[] c = s.ToCharArray();
            bool verification = int.TryParse(c[0].ToString(), out int n);
            return verification;
        }
        catch (System.Exception ex)
        {

            throw new System.Exception(ex.Message);
        }
    }

    public string[] PushBackSplit(string s)
    {
        try
        {
            string x = s;

            List<string> separators = new List<string>().ToList().Concat(reservedWorks.KeyWords).Concat(keyoperations.KeyOperations).ToList();
            foreach (var i in separators)
            {
                s = s.Replace(i, " " + i + " ");
            }

            string[] pbs = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            return pbs;

        }
        catch (System.Exception ex)
        {

            throw new System.Exception(ex.Message);
        }
    }

    public string FiltersVariable(string s)
    {
        try
        {
            string x = s;

            List<string> separators = new List<string>().ToList().Concat(reservedWorks.KeyWords).Concat(keyoperations.KeyOperations).ToList();
            foreach (var i in separators)
            {
                s = s.Replace(i, string.Empty);
            }

            if(IsNumeric(s))
            {
                s = s.Replace(s,string.Empty);
            }

            return s;

        }
        catch (System.Exception ex)
        {

            throw new System.Exception(ex.Message);
        }
    }
}