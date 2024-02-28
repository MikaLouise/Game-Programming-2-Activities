using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floryn : Pokemon
{
    void Start()
    {
        name = "Floryn";
        specialty = Specialty.Poke;
        durability = 32;
        role = Role.Support;

        imagePath = "Sprites/Floryn";
    }

    
}
