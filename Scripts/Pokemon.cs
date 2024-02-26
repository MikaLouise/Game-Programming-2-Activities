using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "Pokemon", menuName = "ScriptableObjects/Pokemon")]
public class Pokemon : ScriptableObject
{
    public new string name;
    public int durability;
    public Specialty specialty;
    public Role role;
    public int abilityEffects;
    public int difficulty;
    public Sprite image;

    public int attack;

    public string imagePath;

}
