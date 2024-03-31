using tpmodul7_kelompok_07;

class Program
{
    static void Main(string[] args)
    {
        DataMahasiswa_1302220104_PRAKTIKAN mhs = new DataMahasiswa_1302220104_PRAKTIKAN();
        mhs.ReadJSON();

        KuliahMahasiswa_1302220104 kuliahMahasiswa = new KuliahMahasiswa_1302220104();
        kuliahMahasiswa.ReadJson2(); 
    
    }
}
