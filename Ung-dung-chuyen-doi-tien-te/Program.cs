using System;

namespace Ung_dung_chuyen_doi_tien_te
{
    class Program
{

        static void Main(string[] args)
        {

            double rate = 23000;

            Console.WriteLine("Nhap so USD ban muon doi sang VND:");
            double usd = Convert.ToDouble(Console.ReadLine());

            double vnd = usd * rate;

            Console.WriteLine($"Gia tri {usd} USD la {vnd} VND.");
        }
    }
}