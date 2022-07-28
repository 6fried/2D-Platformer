using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Overview : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("LookAround");
    }

    private IEnumerator LookAround()
    {
        yield return new WaitForSeconds(2);
        Destroy(this.gameObject);
    }
}
