
//SoalNomer1


Sekolah makananbergizi = new Sekolah("h1", "SDN2", 4000);
Sekolah makananbergizi2 = new Sekolah("h2", "SDN3", 1500);


makananbergizi.HidupJokowi();
makananbergizi.TampilkanInfo();
makananbergizi2.TampilkanInfo();

class Sekolah
{
    public string idSekolah;
    public string namaSekolah;
    public decimal jumlahPaketDiterima;



    public Sekolah(String idSekolah, String namaSekolah, int jumlahPaketDiterima)
    {
        this.idSekolah = idSekolah;
        this.namaSekolah = namaSekolah;
        this.jumlahPaketDiterima = jumlahPaketDiterima;
    }



    public void HidupJokowi()
    {
        Console.WriteLine("Antek antek asing");
    }
    public void TampilkanInfo()
    {
        Console.WriteLine("Username: " + idSekolah);
        Console.WriteLine("nama: " + namaSekolah);
        Console.WriteLine("MBG dapat berapa: " + jumlahPaketDiterima);

    }       
}




//SoalNomer2

Console.WriteLine("susah banget yak PBO tanpa ngelihat apa apa, njirlah");

class paketMBG
{
    public string idPaket;
    public string namaPaket;
    public string stokDapur;
}




//SoalNomer3



class paketMbg
{
    public string idPaket;
    public string namaPaket;
    public string stokDapur;



    class PaketReguler
    {

    }

    class PaketKhusus
    {

    }
}



//SoalNomer4


class paketMbg
{

    public void hitungBiaya()
    {
        
    }

    class PaketReguler
    {

    }

    class PaketKhusus
    {

    }
}



//SoalNomer5


class paketMbg
{
    public void hitungBiaya()
    {

    }
}   

//SoalNomer6



class DistribusiMbg
{
    public string namaSekolah;
    public string paketMbg;
    public string jumlahMbg;


    public void kirimpaket()
    {

    }
}



//Opsional

Console.WriteLine(
    "nama sekolah:" +
    "nama Paket MBG :" +
    "DataMBG: ");

class pengelolaMbg
{
    public void tambahSekolah()
    {

    }
    public void tambahPaket()
    {

    }
    public void tampilkanDataMBG()
    {

    }
}







