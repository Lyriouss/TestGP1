using UnityEngine;

public class Ants : Animals
{
    public override void Start()
    {
        Debug.Log("A giocare");
    }

    public override void Update()
    {
        base.Update();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }
    }

    public override void Attack() 
    {
        base.Attack();
        Debug.Log("L'hai voluto tu!");
    }
}
