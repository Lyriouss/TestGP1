using UnityEngine;

public class AppleTree : Plants
{
    public override void Update()
    {
        //recalls Update() functions in parent class
        base.Update();

        //depending on whether currentWater is at the lowest or highest value, prints in console a message
        if (currentWater >= waterRequested)
        {
            Debug.Log("Ho abbastanza acqua, grazie...");
        }

        if (currentWater <= 0)
        {
            Debug.Log("Posso un po' d'acqua?");
        }
    }
}
