using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotasi : MonoBehaviour
{
    public int kecepatanX, kecepatanY, kecepatanZ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(kecepatanX,kecepatanY,kecepatanZ);
    }
}
