using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Claude : Pokemon
{
    void Start()
    {
        name = "Claude";
        specialty = Specialty.Reap;
        durability = 45;
        role = Role.Marksman;

        imagePath = "Sprites/Claude";
    }
}
