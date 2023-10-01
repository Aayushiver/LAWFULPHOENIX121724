using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemCollection : MonoBehaviour
{
    private int coins = 0;
    [SerializeField] private text;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            coins++;
            Debug.Log("coins: " + coins);
        }
    }
}
