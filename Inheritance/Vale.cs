using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vale : Pokemon
{
    // Start is called before the first frame update
    void Start()
    {
        name = "Vale";
        specialty = Specialty.Burst;
        durability = 47;
        role = Role.Mage;

        imagePath = "Sprites/Vale";
    }

   
}
