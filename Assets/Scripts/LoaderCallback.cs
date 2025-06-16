using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoaderCallback : MonoBehaviour
{
    //private bool isFirstUpdate = true; // Реалістичний варіант використання

    //private void Update()
    //{
    //    if (isFirstUpdate)
    //    {
    //        isFirstUpdate = false;

    //        Loader.LoaderCallback();
    //    }
    //}


    private void Start()
    {
        StartCoroutine(DelayedLoad());
    }

    private IEnumerator DelayedLoad()
    {
        Debug.Log(" Очікування перед переходом до GameScene...");

        yield return new WaitForSeconds(3f); 

        Loader.LoaderCallback(); 
    }
}
