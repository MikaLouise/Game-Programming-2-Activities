using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kagura : Pokemon
{
    void Start()
    {
        name = "Kagura";
        specialty = Specialty.Damage;
        durability = 64;
        role = Role.Mage;

        imagePath = "Sprites/Kagura";
    }
}
