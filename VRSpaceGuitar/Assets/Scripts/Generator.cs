using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public int loops = 10;
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        int sRadius = 1;
        for(int j = 1 ; j < loops ; j ++)
        {
            int r = sRadius + j;
            int num = (int) (Mathf.PI * 2.5f * j * sRadius);
            float theta = (2.0f * Mathf.PI) / (float) num;

            for(int i = 0 ; i < num ; i ++)
            {
                float angle = theta * i;
                float x = Mathf.Sin(angle) * r * 1.1f ;
                float y = Mathf.Cos(angle) * r * 1.1f ;
                GameObject go = GameObject.Instantiate<GameObject>(prefab);
                go.transform.position = new Vector3(x,y, 0);
                go.transform.parent = this.transform;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}