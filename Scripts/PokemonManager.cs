using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PokemonManager : MonoBehaviour
{
    public Pokemon[] pokemons;
    private string folderPath = "Pokemon"; 

    void Awake()
    {
        pokemons = Resources.LoadAll<Pokemon>(folderPath);
    }
}
