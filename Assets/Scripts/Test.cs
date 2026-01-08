using UnityEngine;

public class Test : MonoBehaviour
{
    Incapsulation incapsulation;

    private void Start()
    {
        incapsulation = FindAnyObjectByType<Incapsulation>();

        incapsulation.CurrentHealth = 14;

    }
}
