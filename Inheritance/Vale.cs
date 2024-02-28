using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vale : Pokemon
{
    void Start()
    {
        name = "Vale";
        specialty = Specialty.Burst;
        durability = 47;
        role = Role.Mage;

        imagePath = "Sprites/Vale";
    }

   
}
