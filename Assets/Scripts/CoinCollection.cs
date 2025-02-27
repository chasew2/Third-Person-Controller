using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;
public class CoinCollection : MonoBehaviour
{
    private int Coin = 0;

    public TextMeshProUGUI coinCount;

    private void OnTriggerEnter(Collider other){
        if (other.transform.tag == "Coin"){
            Coin++;
            coinCount.text = "Coin: "+ Coin.ToString();
            Debug.Log(Coin);
            Destroy(other.gameObject);
        }
    }

}
