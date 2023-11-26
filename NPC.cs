using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public float health = 30.0f;
    public int level = 1;
    public float speed = 1.2f;
    public string npcName;
    private Vector3 newPosition;
    [System.NonSerialized]
    private int updLevel = 1;

    void Start()
    {
        print("Health: " + health);
        newPosition = transform.position;
    }

    
    void Update()
    {
        if(updLevel == 1)
        {
            health += level;
            updLevel = 0;
            print("New health: " + health);
        }
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
