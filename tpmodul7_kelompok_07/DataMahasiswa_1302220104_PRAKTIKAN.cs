using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;
namespace tpmodul7_kelompok_07
{
    internal class DataMahasiswa_1302220104_PRAKTIKAN
    {
        public class Nama
        {
            public String depan { get; set; }
            public String belakang { get; set; }
        }
        public Nama nama { get; set; }
        public int nim { get; set; }
        public String fakultas { get; set; }

        public void ReadJSON()
        {
            string filePath = "D:\\New folder\\tpmodul7_kelompok_07\\tpmodul7_kelompok_07\\tp7_1_1302220104.json";

            string jsonText = File.ReadAllText(filePath);

            DataMahasiswa_1302220104_PRAKTIKAN dataMahasiswa = JsonSerializer.Deserialize<DataMahasiswa_1302220104_PRAKTIKAN>(jsonText);

            Console.WriteLine($"Nama {dataMahasiswa.nama.depan} {dataMahasiswa.nama.belakang} dengan NIM {dataMahasiswa.nim} dari Fakultas {dataMahasiswa.fakultas}");
        }
    }   
}
