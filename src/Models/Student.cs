using System;
using HogwartsHouses.Models.Types;

namespace HogwartsHouses.Models
{
    [System.Serializable]
    public class Student
    {
        public string Name { get; set; }

        public HouseType HouseType { get; set; }

        public PetType PetType { get; set; }

        public Student(string name, HouseType houseType, PetType petType)
        {
            Name = name;
            HouseType = houseType;
            PetType = petType;
        }



    }
}
