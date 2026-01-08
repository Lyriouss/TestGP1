using UnityEngine;

public class Polymorphism : MonoBehaviour
{
    //Animals animal;
    IWaterConsumption waterConsumer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //animal = FindAnyObjectByType<Animals>();
        waterConsumer = GetComponent<IWaterConsumption>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
