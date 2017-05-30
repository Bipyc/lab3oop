using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Tanks_Serialize
{
    [DataContract]
    abstract class Tank
    {
        [DataMember]
        int massa;
        [DataMember]
        string national;
    }
    /*DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Person[]));
 
            using (FileStream fs = new FileStream("people.json", FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs, people);
            }
 
            using (FileStream fs = new FileStream("people.json", FileMode.OpenOrCreate))
            {
                Person[] newpeople = (Person[])jsonFormatter.ReadObject(fs);
 
                foreach (Person p in newpeople)
                {
                    Console.WriteLine("Имя: {0} --- Возраст: {1}", p.Name, p.Age);
                }
            }
 */
            Console.ReadLine();
}
