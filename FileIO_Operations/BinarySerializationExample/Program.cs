using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace BinarySerializationExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String path = @"D:\Infoway\.Net\VehicleSerialize.dat";
            BinaryFormatter formatter = new BinaryFormatter();

            // using block is use to automatic disposal of file/network/db variable
            
            using (FileStream st = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                Vehicle v1 = new Vehicle() { VehicleId=1289,Type= "SUV" , NoOfSeats= 5 };
                formatter.Serialize(st, v1);
                st.Close();
            }


            using (FileStream ST = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                Vehicle cl = formatter.Deserialize(ST) as Vehicle;
                Console.WriteLine($"Vehicle {cl.VehicleId} - {cl.Type} - {cl.NoOfSeats}");
                ST.Close();
            }


            Console.WriteLine("Done..!!");
            Console.ReadKey();
        }
    }
}
