using UnityEngine;

public abstract class Plants : Nature, IWaterConsumption
//public class will remain abstract for the child classes
{
    public KeyCode drinkButton;              //the button to hold down to give the plant water to drink
    public float currentWater;               //current amount of water the plant already drank
    public float waterRequested;             //the amount of water the plant requests
    public float absorptionRate;             //the rate at which the plant absorbs water
    public float waterConsumptionRate;       //the rate at which the plant consumes the water

    public virtual void Update()
    {
        //FUTURE REFERENCE
        //add the conditions outside the function to lighten the programm instead jumping in and out of the function

        //while input button is pressed AND currentWater doesn't exceed how much is requested (or max)
        if (Input.GetKey(drinkButton) && currentWater < waterRequested)
        {
            DrinkWater();
        } //if input button is not currently pressed AND currentWater is greater than 0
        else if (!Input.GetKey(drinkButton) && currentWater > 0)
        {
            ConsumeWater();
        }
    }
    //the update that contains the functions is virtual so the child classes may use it without recalling the functions

    public void DrinkWater()
    {
        //currentWater will gradually increase according to absorptionRate
        currentWater += absorptionRate * Time.deltaTime;
    }

    public void ConsumeWater()
    {
        //currentWater will gradually decrease according to waterConsumptionRate
        currentWater -= waterConsumptionRate * Time.deltaTime;
    }
}
