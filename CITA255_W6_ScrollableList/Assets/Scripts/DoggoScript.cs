using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class DoggoScript : MonoBehaviour
{
    public SpriteRenderer dogSprite;
    public TextMeshProUGUI dogText;

    public DogBreed dogBreed;

    public enum DogBreed
    {
        AustralianShepherd,
        Beagle,
        BorderCollie,
        ChowChow,
        Corgi,
        ShibaInu,
        GoldenRetriever,
        LabradorRetriever,
        Maltipoo,
        ShetlandSheepdog
    }

    void Start()
    {
        UpdateDogInfo();
    }

    public void UpdateDogInfo()
    {
        switch (dogBreed)
        {
            case DogBreed.AustralianShepherd:
                dogText.text = "Australian Shepherd\nVery good dog.";
                dogSprite.sprite = Resources.Load<Sprite>("australian");
                break;
            case DogBreed.Beagle:
                dogText.text = "Beagle\nThe happiest dog in the world.";
                dogSprite.sprite = Resources.Load<Sprite>("beagle");
                break;
            case DogBreed.BorderCollie:
                dogText.text = "Border Collie\nIf you are not as smart, stay away from this dog.";
                dogSprite.sprite = Resources.Load<Sprite>("border"); 
                break;
            case DogBreed.ChowChow:
                dogText.text = "Chow Chow\nSome people say they are super aggressive, but they were " +
                               "indeed bred to be guard dogs. But they can be really sweet!";
                dogSprite.sprite = Resources.Load<Sprite>("chow");
                break;
            case DogBreed.Corgi:
                dogText.text = "Corgi\nThe Queen had this dog for many years.";
                dogSprite.sprite = Resources.Load<Sprite>("corgi");
                break;
            case DogBreed.ShibaInu:
                dogText.text = "Shiba Inu\nThe Japanese dog that was turned into a meme. RIP.";
                dogSprite.sprite = Resources.Load<Sprite>("doge");
                break;
            case DogBreed.GoldenRetriever:
                break;
            case DogBreed.LabradorRetriever:
                break;
            case DogBreed.Maltipoo:
                break;
            case DogBreed.ShetlandSheepdog:
                break;
            default:
                Debug.Log("You probably didn't pass a dog breed into the object. " +
                          "Perhaps you made a boo-boo?");
                break;
        }
    }

}
