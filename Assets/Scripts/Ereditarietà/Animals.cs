using UnityEngine;

public abstract class Animals : Nature, IWaterConsumption
//quando abstract è messo nella classe, l'informazione non esiste e serve soltanto per leggerlo
{
    public float hunger;
    public float thirst;
    public float tiredness;

    public virtual void Start()
    {
        Debug.Log("Si inizia");
    }

    public virtual void Update()
    {
        if (Input.GetKey(KeyCode.Return) && thirst > 0)
        {
            //thirst lowers gradually as the animal drinks
            DrinkWater();
        }
        //if the button is not pressed then thirst will increase infinitely
        else if (!Input.GetKey(KeyCode.Return))
        {
            ConsumeWater();
        }
    }

    public virtual void Attack()
    //virtual è usato quando vuoi usare override nella child classe
    {
        Debug.Log("Attacco");
    }

    //2 functions implemented thanks to the interface
    public void DrinkWater()
    {
        thirst -= Time.deltaTime;
    }

    public void ConsumeWater()
    {
        thirst += Time.deltaTime;
    }
}
