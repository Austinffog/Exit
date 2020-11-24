using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene : MonoBehaviour
{
    public float interval = 2f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, interval);
    }

}
