using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sciptotmena : MonoBehaviour
{
    private AudioSource _AudioSource;

    private void Awake()
    {
        _AudioSource = GetComponent<AudioSource>();

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _AudioSource.Stop();
        }
    }
}
