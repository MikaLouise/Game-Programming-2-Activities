using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PokemonButton : MonoBehaviour
{
    public TextMeshProUGUI pokemonNameTxt;

    public void SetPokemonData(Pokemon unit)
    {
        pokemonNameTxt.text = unit.name;
    }
}
