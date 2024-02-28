using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Karina : Pokemon
{
    void Start()
    {
        name = "Karina";
        specialty = Specialty.Charge;
        durability = 45;
        role = Role.Assassin;

        imagePath = "Sprites/Karina";
    }

   
}
