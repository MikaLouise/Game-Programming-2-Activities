using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PokemonInfoView : MonoBehaviour
{
    public Pokemon pokemon;

    [Header("UI Headers")]
    public TextMeshProUGUI nameTMP;
    public TextMeshProUGUI specialtyTMP;
    public TextMeshProUGUI roleTMP;
    public TextMeshProUGUI durabilityTMP;
    public TextMeshProUGUI offenseTMP;
    public TextMeshProUGUI abilityEffectsTMP;
    public TextMeshProUGUI difficultyTMP;
    public Image pokemonImage;

    public void OnEnable()
    {
        DisplayPokemon(pokemon);
    }

    public void DisplayPokemon(Pokemon pokemon)
    {
        nameTMP.text = pokemon.name;
        specialtyTMP.text = pokemon.specialty.ToString();
        roleTMP.text = pokemon.role.ToString();
        durabilityTMP.text = pokemon.durability.ToString();
        offenseTMP.text = pokemon.attack.ToString();
        abilityEffectsTMP.text = pokemon.abilityEffects.ToString();
        difficultyTMP.text = pokemon.difficulty.ToString();

        if (pokemon.image != null)
        {
            pokemonImage.sprite = pokemon.image;
        }
    }

    public void ClearView()
    {
        pokemon = null;
        nameTMP.text = null;
        specialtyTMP.text = null;
        roleTMP.text = null;
        durabilityTMP.text = null;
        offenseTMP.text = null;
        abilityEffectsTMP.text = null;
        difficultyTMP.text = null;
    }

    public void OnDisable()
    {
        ClearView();
    }
}
