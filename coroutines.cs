using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coroutines : MonoBehaviour
{
    private Coroutine myCoroutine;
    private void Start()
    {
        myCoroutine = StartCoroutine(DoStuff());
    }

    private IEnumerator DoStuff()
    {
        yield return new WaitForSeconds(3f);
        Debug.Log("Coroutine");
    }

}
