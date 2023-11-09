// MohammadReza Fatahi
// t.me/SirNopo
// tamrin 7

while (true)
{
first:
    Console.WriteLine("Salam Khosh Amadid !");
    Console.WriteLine("Lotfan Name Morde Nazar Khod Ra Vared Namaeed.");
    string name = Console.ReadLine();
    string namelist = " hossein ali mohsen bahram kazem behrooz amir sina hasan mohammad eskandar reza mahram bahram shahram shadmehr ebi korosh ehsan ahmad salar sorena avesta ramin alireza mobin saeid moein mehdi sadegh jalal bohlol masood erfan majid omid mehrdad hesam iliya ashkan bardiya benjamin babak behnam pooya khosro daryoosh sirvan sadra sobhan shahab zahra fatemeh reyhaneh homa sara mona azita nazanin niloofar nastaran helen asal ava ghazal hana mersana aseman darya donya baran ayda maedeh negar negin samira elnaz elham narges ameneh zeynab nasrin mahnaz bahar niki sadaf nahid akram james ben kevin marco selena antony taylor alan maria roze harry nicolas";
    if (namelist.Contains(name.ToLower()))
    {

        tabe();

    }
    else
    {
        Console.WriteLine(System.Environment.NewLine + "=====================" + "Name Vared Shode Peyda Nashod" + "=====================" + System.Environment.NewLine);

    }
    void tabe()
    {
        Random rnd = new Random();
        int pishrafte = rnd.Next(20);
        int tafsir = rnd.Next(20);
        int riazi = rnd.Next(20);
        int kargah = rnd.Next(20);
        int zaban = rnd.Next(20);
        int pishrafte2 = rnd.Next(20);
        int shey = rnd.Next(20);
        int tabiatbadani = rnd.Next(20);
        int OS = rnd.Next(20);
        int Algo = rnd.Next(20);
        int moadel = ((3 * pishrafte) + (tafsir) + (2 * riazi) + (kargah) + (2 * zaban) + (3 * pishrafte2) + (shey * 3) + (tabiatbadani) + (OS * 3) + (Algo * 3)) / (22);
        string ps = pishrafte.ToString();
        string tf = tafsir.ToString();
        string rz = riazi.ToString();
        string kr = kargah.ToString();
        string zb = zaban.ToString();
        string ps2 = pishrafte2.ToString();
        string sh = shey.ToString();
        string tb = tabiatbadani.ToString();
        string oos = OS.ToString();
        string al = Algo.ToString();
        string srs = "2 3 5 7 11 13 17 19";
        string grade = "";
        if (srs.Contains(ps))
        {
            if (ps == "1")
            {

            }
            else if (ps == "9")
            {

            }
            else
            {
                ps = ps + " Prime Number";
            }
        }
        if (srs.Contains(tf))
        {
            if (tf == "1")
            {

            }
            else if (tf == "9")
            {

            }
            else
            {
                tf = tf + " Prime Number";
            }
        }
        if (srs.Contains(kr))
        {
            if (kr == "1")
            {

            }
            if (kr == "9")
            {

            }
            else
            {
                kr = kr + " Prime Number";
            }
        }
        if (srs.Contains(zb))
        {
            if (zb == "1")
            {

            }
            else if (zb == "9")
            {

            }
            else
            {
                zb = zb + " Prime Number";

            }
        }
        if (srs.Contains(ps2))
        {
            if (ps2 == "1")
            {

            }
            else if (ps2 == "9")
            {

            }
            else
            {


                ps2 = ps2 + " Prime Number";
            }
        }
        if (srs.Contains(sh))
        {
            if (sh == "1")
            {

            }
            else if (sh == "9")
            {

            }
            else
            {


                sh = sh + " Prime Number";
            }
        }
        if (srs.Contains(tb))
        {
            if (tb == "1")
            {

            }
            else if (tb == "9")
            {

            }
            else
            {
                tb = tb + " Prime Number";
            }
        }
        if (srs.Contains(oos))
        {
            if (oos == "1")
            {

            }
            else if (oos == "9")
            {

            }
            else
            {


                oos = oos + " Prime Number";
            }
        }
        if (srs.Contains(al))
        {
            if (al == "1")
            {

            }
            else if (al == "9")
            {

            }
            else
            {
                al = al + " Prime Number";
            }
        }
        if (srs.Contains(rz))
        {
            if (rz == "1")
            {

            }
            else if (rz == "9")
            {

            }
            else
            {
                rz = rz + " Prime Number";
            }
        }
        if (moadel >= 17)
        {
            grade = " A ";
        }
        else if (moadel >= 15)
        {

            grade = " B ";


        }
        else if (moadel >= 13)
        {

            grade = " C ";


        }
        else if (moadel >= 10)
        {

            grade = " D ";


        }
        else if (moadel >= 7)
        {

            grade = " E ";


        }
        else if (moadel >= 3)
        {

            grade = " F ";


        }
        else if (moadel >= 0)
        {

            grade = " G ";


        }
        Console.WriteLine("Name : " + name + "             " + "Grade : " + grade + System.Environment.NewLine + "=====================");
        Console.WriteLine("Pishrafte 1 : " + ps);
        Console.WriteLine("Tafsir: " + tf);
        Console.WriteLine("Riazi: " + rz);
        Console.WriteLine("Kargah: " + kr);
        Console.WriteLine("Zaban Khareji : " + zb);
        Console.WriteLine("Pishrafte 2 : " + ps2);
        Console.WriteLine("SheyGaraee : " + sh);
        Console.WriteLine("Tarbiat Badani : " + tb);
        Console.WriteLine("System Amel : " + oos);
        Console.WriteLine("Algorithm : " + al);
        Console.WriteLine("Moadel : " + moadel + " " + grade);
        Console.WriteLine("=====================" + System.Environment.NewLine);

    }



}