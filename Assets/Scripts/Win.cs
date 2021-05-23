using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject winScreen;

    void OnTriggerEnter(Collider col)
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        winScreen.SetActive(true);
    }
}
