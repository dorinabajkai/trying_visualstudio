using System;
using System.Xml.Serialization;

namespace hf1
{
    [XmlRoot("Személy")]
    public class Person
    {
       // private String name;
        private int age;

        public event AgeChangingDelegate AgeChanging;

        [XmlIgnore]
        public string Name { get; set; }

        [XmlAttribute("Kor")]
        public int Age
        {
            get { return age; }
            set 
            { 
                if (value < 0)
                    throw new Exception("Érvénytelen életkor!");
                if (AgeChanging != null)
                    AgeChanging(age, value);
                age = value; 
            }   
        }

    }
}
