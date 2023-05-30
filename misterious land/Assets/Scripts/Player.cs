using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player instance;
    public int currentHealth;
    public int maxHealth = 3;
    void Start()
    {
        currentHealth = maxHealth;
    }

    private void Awake()
    {
        instance = this;
    }
}