using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddenMan : MonoBehaviour
{
    public GameObject player;
    public GameObject X;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = (player.transform.position + X.transform.position) / 2;
    }
}
