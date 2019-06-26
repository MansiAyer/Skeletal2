using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiles : MonoBehaviour {

    public GameObject[] tile;
    public Transform player;
    public float tz = 0.0f;
    public float tl = 8.4f;
    public int tn = 3;
    public List<GameObject> activetiles;
    public float safe = 15.0f;
    // Use this for initialization
    void Start() {
        activetiles = new List<GameObject>();
        player = GameObject.FindGameObjectWithTag("Player").transform;

        for (int i = 0; i < tn; i++)
        {
            spawn();
        }
    }

    // Update is called once per frame
    void Update() {
        if (player.position.z - safe> (tz - tn * tl))
        {
            spawn();
            Delete();
        }
            
    }

    void spawn(int prefabIndex = -1)
    {
        GameObject g = Instantiate(tile[0]);
        g.transform.SetParent(transform);
        g.transform.position = Vector3.forward * tz;
        tz += tl;
        activetiles.Add(g);
    }

    void Delete()
    {
        Destroy(activetiles[0]);
        activetiles.RemoveAt(0);

    }
}
