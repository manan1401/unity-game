using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_capsule : MonoBehaviour
{

    public GameObject capsule_spawn;
    int x, y, z;
    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        y = 1;
        z = 0;

        InvokeRepeating("capsule_spawn_prefab", 2, 2);
    }

    // Update is called once per frame
    void capsule_spawn_prefab()
    {
        x = Random.Range(-20 ,20);
        z = Random.Range(-20, 20);
        Instantiate(capsule_spawn, new Vector3(x,y,z) , Quaternion.identity);

    }
    //
}
