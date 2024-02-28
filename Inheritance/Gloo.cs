using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gloo : Pokemon
{
    void Start()
    {
        name = "Gloo";
        specialty = Specialty.CrowdControl;
        durability = 92;
        role = Role.Tank;

        imagePath = "Sprites/Gloo";
    }

    
}
