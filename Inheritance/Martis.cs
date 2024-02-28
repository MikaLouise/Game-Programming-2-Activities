using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Martis : Pokemon
{
    void Start()
    {
        name = "Martis";
        specialty = Specialty.Reap;
        durability = 65;
        role = Role.Fighter;

        imagePath = "Sprites/Martis";
    }

}
