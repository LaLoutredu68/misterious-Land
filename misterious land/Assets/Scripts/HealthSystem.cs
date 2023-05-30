using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
    [SerializeField] Sprite emptyHeart, fullHeart;
    [SerializeField] Image life1, life2, life3;

    void Start()
    {
        
    }

    void Update()
    {
        switch (Player.instance.currentHealth)
        {
            case 3:
                life3.sprite= fullHeart;
                life2.sprite= fullHeart;
                life1.sprite= fullHeart;
                break;
            case 2:
                life3.sprite= emptyHeart;
                life2.sprite= fullHeart;
                life1.sprite= fullHeart;
                break;
            case 1:
                life3.sprite= emptyHeart;
                life2.sprite= emptyHeart;
                life1.sprite= fullHeart;
                break;
            case 0:
                life3.sprite= emptyHeart;
                life2.sprite= emptyHeart;
                life1.sprite= emptyHeart;
                break;
        }
    }
}
