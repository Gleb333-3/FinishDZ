using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class image : MonoBehaviour
{
    [SerializeField]
    private GameObject _image;
    void Start()
    {
        _image.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _image.SetActive(true);
        }
    }
}
