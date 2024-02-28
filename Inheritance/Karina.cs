using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Karina : Pokemon
{
    // Start is called before the first frame update
    void Start()
    {
        name = "Karina";
        specialty = Specialty.Charge;
        durability = 45;
        role = Role.Assassin;

        imagePath = "Sprites/Karina";
    }

   
}
