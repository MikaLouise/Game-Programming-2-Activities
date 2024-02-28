using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Martis : Pokemon
{
    // Start is called before the first frame update
    void Start()
    {
        name = "Martis";
        specialty = Specialty.Reap;
        durability = 65;
        role = Role.Fighter;

        imagePath = "Sprites/Martis";
    }

}
