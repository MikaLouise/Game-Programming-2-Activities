using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wanwan : Pokemon
{
    void Start()
    {
        name = "Wanwan";
        specialty = Specialty.Reap;
        durability = 43;
        role = Role.Marksman;

        imagePath = "Sprites/Wanwan";
    }

    
}
