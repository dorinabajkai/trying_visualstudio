using System;
using System.IO;
using System.Xml.Serialization;

namespace hf2
{
    //public delegate bool Predicate<T>(T obj);
    public delegate void CouncilChangedDelegate(string change);
    class Program
    {
        static void CouncilChanged(string change)
        {
            Console.WriteLine(change);
        }

        static void Main(string[] args)
        {
            Council council = new Council();
            council.ChangedCouncil += CouncilChanged;
            FillCouncil(council);

            Jedi jedi = new Jedi();
            jedi.Name = "Obi-Wan";
            jedi.MidiChlorianCount = 15000;

            council.Add(jedi);
           
            Console.WriteLine("Név: {0}, Midi-chlorian szám: {1}", jedi.Name, jedi.MidiChlorianCount);
            Jedi clone = Program.SerializerMethod(jedi);
            council.Add(clone);
            Console.WriteLine("Név: {0}, Midi-chlorian szám: {1}", clone.Name, clone.MidiChlorianCount);

            PrintBeginners(council);
            Console.WriteLine(council.Count);
            Console.WriteLine(council.CountIf(BeginnerFilter));

            council.Remove();
            council.Remove();


        }

        public static Jedi SerializerMethod(Jedi jedi) 
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Jedi));
            FileStream stream = new FileStream("jedi.txt", FileMode.Create);
            serializer.Serialize(stream, jedi);
            stream.Close();

            stream = new FileStream("jedi.txt", FileMode.Open);
            Jedi clone = (Jedi)serializer.Deserialize(stream);
            stream.Close();

            return clone;
        }

        public static void FillCouncil(Council council)
        {
            Jedi jedi1 = new Jedi();
            Jedi jedi2 = new Jedi();
            Jedi jedi3 = new Jedi();

            jedi1.Name = "Anakin";
            jedi1.MidiChlorianCount = 20000;
            jedi2.Name = "Beginner1";
            jedi2.MidiChlorianCount = 250;
            jedi3.Name = "Beginner2";
            jedi3.MidiChlorianCount = 200;

            council.Add(jedi1);
            council.Add(jedi2);
            council.Add(jedi3);
        }

        public static void PrintBeginners(Council council)
        {
            foreach(Jedi jedi in council.GetBeginners())
            {
                Console.WriteLine("Név: {0}, Midi-chlorian szám: {1}", jedi.Name, jedi.MidiChlorianCount);
            }
        }

        static bool BeginnerFilter(Jedi jedi)
        {
            return jedi.MidiChlorianCount < 300 ? true : false;
        }
    }
}
