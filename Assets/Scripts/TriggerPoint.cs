using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPoint : MonoBehaviour
{
    public GameObject Point;

    void OnTriggerEnter(Collider col)
    {
        Point.SetActive(false);
        Destroy(this.gameObject);
    }
}
