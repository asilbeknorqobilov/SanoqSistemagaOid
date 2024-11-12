namespace Dasturlash_topshiriq;

public class Satr
{
    public string gap;
    public string[] sozlar;

    public Satr(string gap)
    {
        this.gap = gap;
        this.ajratish();
    }

    private void ajratish()
    {
        gap = gap.Replace(',', ' ');
        sozlar = gap.Split(' ');
    }

    public string[] bir_marta()
    {
        string[] nat = new string[sozlar.Length];
        int q = 0;
        foreach (var soz in sozlar)
        {
            int c = this.sanash(soz);
            if (c == 1)
            {
                nat[q] = soz;
                q++;
            }
        }

        return nat;
    }
    
    public string[] bir_necha()
    {
        string[] nat = new string[sozlar.Length];
        int q = 0;
        foreach (var soz in sozlar)
        {
            int c = this.sanash(soz);
            if (c > 1 && !nat.Contains(soz))
            {
                nat[q] = soz;
                q++;
            }
        }
    
        return nat;
    }


    // public string[] bir_necha()
    // {
    //     List<string> royxat = new List<string>();
    //
    //     for (int i = 0; i < sozlar.Length; i++)
    //     {
    //         bool takror = false;
    //         for (int j = i + 1; j < sozlar.Length; j++)
    //         {
    //             if (sozlar[i] == sozlar[j])
    //                 takror = true;
    //         }
    //
    //         if (takror)
    //         {
    //             royxat.Add(sozlar[i]);
    //         }
    //     }
    //
    //     return royxat.ToArray();
    // }

    // public string[] bir_necha()
    // {
    //     for (int i = 0; i < sozlar.Length; i++)
    //     {
    //         bool c = false;
    //         for (int j = i + 1; j < sozlar.Length; j++)
    //         {
    //             if (sozlar[i] == sozlar[j])
    //                 c = true;
    //         }
    //
    //         if (c)
    //         {
    //             Console.WriteLine(sozlar[i]);
    //         }
    //     }
    //     return 
    // }

    public string[] alfabit()
    {
        string[] alfa = new string[sozlar.Length];
        gap = gap.Replace(',', ' ');
        string[] massiv = gap.Split(' ');
        foreach (var nat in sozlar)
        {
            Array.Sort(sozlar);
        }

        return sozlar;
    }

    private int sanash(string soz)
    {
        int c = 0;
        for (int i = 0; i < sozlar.Length; i++)
        {
            if (soz == sozlar[i])
            {
                c++;
            }
        }

        return c;
    }

    public override string ToString()
    {
        return this.gap;
    }
}