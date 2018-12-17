using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatSpawnerScript : MonoBehaviour {
    public GameObject camp;
    public GameObject Ocat;
    public GameObject Bcat;
    int index;

    float rand;
    float rand2;
    float nextSpawn = 0.0f;
    float nextSpawn2 = 0.0f;

    public float lifetime;
    private float start;
    private int randomPicker;
    public Vector2 spawnPosition;
    private Vector2 position1 = new Vector3(-10.5f, -3.6f);
    public float speed;

    void Start()
    {
        rand = 6;
        rand2 = 3;

    }

    // Update is called once per frame
    void Update () {

        if (Time.time > nextSpawn)
        {

            index = Random.Range(0, 1);

            GameObject camp1 = Instantiate(camp, spawnPosition, Quaternion.identity) as GameObject;

            camp1.transform.position = Vector3.MoveTowards(camp1.transform.position, position1, speed);
            rand = Random.Range(4, 8);
            nextSpawn = Time.time + rand;

            Destroy(camp1, lifetime);

        }

        if (Time.time > nextSpawn2)
        {

            index = Random.Range(0, 1);
            GameObject pick = Ocat;

            if (Random.Range(0, 2) > .7)
            {
                pick = Bcat;
            }

            GameObject cat1 = Instantiate(pick, spawnPosition, Quaternion.identity) as GameObject;


            cat1.transform.position = Vector3.MoveTowards(cat1.transform.position, position1, speed);
            rand2 = Random.Range(2, 4);
            nextSpawn2 = Time.time + rand2;

            Destroy(cat1, lifetime);

        }

    }
}
