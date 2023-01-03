using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class schmackofatzi : MonoBehaviour
{
    public AudioSource schmackofatziKaloratzi;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            schmackofatziKaloratzi.Play();
        }
            
    }

    private void Start()
    {
        schmackofatziKaloratzi.Stop();
    }
}
