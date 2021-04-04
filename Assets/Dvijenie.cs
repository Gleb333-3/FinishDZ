using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dvijenie : MonoBehaviour
{
    [SerializeField]
    private Vector3 _direction;
    [SerializeField]
    private float _speed;

    // Update is called once per frame
    void Update()
    {
        _direction.x = Input.GetAxis("Horizontal");
        _direction.z = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
        var mov = _direction * (_speed * Time.deltaTime);
        transform.Translate(mov);
    }
}
