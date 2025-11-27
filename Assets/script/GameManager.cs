using JetBrains.Annotations;
using UnityEngine;
using TMPro;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float ForceLevel;
    public float NumberTio;
    public TextMeshProUGUI LevelOfStrenght;
    public TextMeshProUGUI NumberOfTio;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        NumberTio = 0F;
        ForceLevel = 0F;
  
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void GiveLifeToTio()
    {
        NumberTio += 1F;
        NumberOfTio.text = NumberTio.ToString("00");
        

    }
        
    public void EatTio()
    {
        NumberTio -= 1F;
        NumberOfTio.text = NumberTio.ToString("00");
        ForceLevel += 1F;
        LevelOfStrenght.text = ForceLevel.ToString("00");
    }
       
    public void GainForce()
    {
        
    }
}
