
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Colliders : MonoBehaviour
{
    Bowmover bow;
    static private int Score,scorex,scorey;
    public Text Scoretext;
    public Text Arrows;
    public Text Gameover;
    static public int arrowcount=20;
       // Use this for initialization
    void Start()
    {
        bow = GetComponent<Bowmover>();
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Yes, It is");

        if (this.tag == "FirstTar")
        {
            Score += 40;
            arrowcount -= 1;

        }
        else if (this.tag == "SecondTar")
        { scorex += 20; arrowcount -= 1; }

        else if (this.tag == "ThirdTar")
        { scorey += 10; arrowcount -= 1; }
            Debug.Log(Score+scorex+scorey);

        Scoretext.text = "Score:"+(Score+scorex+scorey).ToString();

        yield return StartCoroutine(Wait(2.0f));

         Arrows.text = "Arrowsleft:" + arrowcount.ToString();
       // Arrows.text = "Arrowsleft:" + bow.arrowsleft.ToString();
        //bow.Pre = Instantiate(bow.prefab.gameObject, bow.rb.position, Quaternion.identity);
        Destroy(collision.gameObject);
        if (arrowcount <=0)
        { print("endgame");
            Gameover.text="Gamover"+"\n"+ " Score:"+ (Score + scorex + scorey).ToString();
            Application.Quit();
            // yield return StartCoroutine(Wait(2.0f));

        }
            
}
    IEnumerator Wait(float time)
    {
        yield return new WaitForSeconds(time);
        Debug.Log("Yes");
       
    }
}

