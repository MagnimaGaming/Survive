using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public AudioSource coinsound;
    private int coinsCollected;
    [SerializeField] private TextMeshProUGUI scoreText;
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coins")
        {
            if(coinsound != null)
            {
                coinsound.Play();
            }
            Destroy(other.gameObject);
            
        }

    }
}
