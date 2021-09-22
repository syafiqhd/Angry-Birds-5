using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OwlBird : Bird
{
    [SerializeField]
    public GameObject explosion;
    public bool _hasExplode = false;

    public void Explode()
    {
        if (!_hasExplode)
        {
            Instantiate(explosion, transform.position, Quaternion.identity);
            _hasExplode = true;
        }
    }

    public override void OnTap()
    {
        Explode();
    }
}
