
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bowmover : MonoBehaviour
{
    public Rigidbody2D rb;
    public float max, min, dir;
    public GameObject prefab;
    public float thrust;
    public Rigidbody2D rbc;
    public GameObject Pre;
    //public Text ScoreText;
    public int Sco;
    public int arrowsleft=20;
    //Coll collide;
    public 
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rbc = GetComponent<Rigidbody2D>();
       // ScoreText = GetComponent<Text>();
        //collide = GetComponent<Coll>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.position.y <= min || rb.position.y >= max)
        {
            dir = -dir;
        }
        rb.velocity = new Vector3(0, dir, 0);
        print(Sco);
        
    }
    public void Onshoot()
    {
        Pre = Instantiate(prefab, rb.position, Quaternion.identity);
        Pre.GetComponent<Rigidbody2D>().velocity = new Vector3(4.0f * thrust, 0, 0);
        arrowsleft -= 1;
    }
}