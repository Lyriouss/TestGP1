using UnityEngine;

public class Rose : Plants
{
    public override void Update()
    {
        //recalls Update() functions in parent class
        base.Update();

        //depending on whether currentWater is at the lowest or highest value, prints in console a message
        if (currentWater >= waterRequested)
        {
            Debug.Log("BASTA ACQUA! MI ANNEGHI!");
        }

        if (currentWater <= 0)
        {
            Debug.Log("HO SETE!!!");
        }
    }
}
