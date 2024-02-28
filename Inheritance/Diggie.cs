using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diggie : Pokemon
{
    void Start()
    {
        name = "Diggie";
        specialty = Specialty.CrowdControl;
        durability = 65;
        role = Role.Support;

        imagePath = "Sprites/Diggie";
    }

}
