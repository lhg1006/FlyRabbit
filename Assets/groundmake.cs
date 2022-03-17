using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundmake : MonoBehaviour
{
    public GameObject Ground;
    public float timeDiff;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timeDiff)
        {
            GameObject newGround = Instantiate(Ground);
            newGround.transform.position = new Vector3(10, 1.57f ,0);
            timer = 0;
            Destroy(newGround, 7);
        }
        
    }
}
