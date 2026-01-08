using JetBrains.Annotations;
using UnityEngine;

public class Incapsulation : MonoBehaviour
{
    //[SerializeField] private int currentHP;
    //public float CurrentHP => currentHP; //lambda

    //public void Function() => currentHP = 0; //questa funzione porta l'HP a 0

    //public void Function()
    //{
    //    currentHP = 0;
    //}

    //public float CurrentHealth { get; private set; }
    // public float CurrentHealth
    //                          è accessibile e modificabile dappertutto
    // { get; }                 è accessibile dappertutto ma non modificabile
    // { get; private set; }    è accessibile dappertutto ma modificabile solo all'interno della classe
    // { get; set; }            è accessibile e modificabile dappertutto

    private float currentHealth = 100;
    public float CurrentHealth 
    {
        get { return currentHealth; } //get di CurrentHealth, dà il valore di currentHealth
        set { currentHealth = value; } //qui si modifica anche la variabile d'origine
    }

    private void Start()
    {
        Debug.Log(currentHealth);
    }
}
