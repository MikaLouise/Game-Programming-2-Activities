using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minotaur : Pokemon
{
    void Start()
    {
       name = "Minotaur";
       specialty = Specialty.CrowdControl;
       durability = 90;
       role = Role.Tank;

        imagePath = "Sprites/Minotaur";
    }

}
