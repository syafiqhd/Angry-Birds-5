using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndExplosion : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(EndTime());
    }

    IEnumerator EndTime() 
    {
        yield return new WaitForSeconds(0.2f);
        gameObject.SetActive(false);
    }
}
