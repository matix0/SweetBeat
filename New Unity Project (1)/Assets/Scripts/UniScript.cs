using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform baixo;

    public Transform cima;

    public GameObject thePlayer;

    void Update()
    {
        if (Input.GetKeyDown("up"))
        {
            thePlayer.transform.position = cima.transform.position;
        }

        if (Input.GetKeyDown("down"))
        {
            thePlayer.transform.position = baixo.transform.position;
        }
    }

    // void OnTriggerEnter2D(Collider2D col)
    // {
    //     if (col.gameObject.tag.Equals("Note"))
    //     {
    //         ScoreScript.scoreValue += 1;
    //         Destroy(col.gameObject);
    //     }
    // }
    
}
