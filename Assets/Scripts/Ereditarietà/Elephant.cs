using JetBrains.Annotations;
using UnityEngine;

public class Elephant : Animals
{
    public override void Start()
    {
        
    }
    public override void Update()
    {
        base.Update();

        if (hunger <= 0 || thirst <= 0 || tiredness <= 0)
        {
            Attack();
        }
        //attack = "Attacco" + "Ora schiaccio tutti!"
    }

    public override void Attack()
    //override sovrascrive la funzione Attack() nella parent class
    //override può essere usato soltanto se la funzione a cui sovrascrive è messo come virtual
    {
        base.Attack();
        //base. richiama cio che è presente nella funzione della parent
        Debug.Log("Ora schiaccio tutti!");
    }
}
