using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace tpmodul7_kelompok_07
{
    internal class MataKuliah
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    internal class KuliahMahasiswa_1302220104
    {
        public List<MataKuliah> courses { get; set; }

        public void ReadJson2()
        {
            string filePath = "D:\\New folder\\tpmodul7_kelompok_07\\tpmodul7_kelompok_07\\tp7_2_1302220104.json";
            string jsonContent = File.ReadAllText(filePath);
            var kuliahMahasiswa = JsonSerializer.Deserialize<KuliahMahasiswa_1302220104>(jsonContent);

            
            Console.WriteLine("Daftar mata kuliah yang diambil:");
            foreach (var course in kuliahMahasiswa.courses)
            {
                Console.WriteLine($"MK {course.code} - {course.name}");
            }
        }
    }
    }
