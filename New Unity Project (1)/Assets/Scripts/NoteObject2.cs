using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject2 : MonoBehaviour
{
    public bool canBePressed;

    public KeyCode keyToPress;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            if (canBePressed)
            {
                ScoreScript.scoreValue += 1;

            }
        }
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player" || col.gameObject.tag == "Player2")
        {
            canBePressed = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player" || col.gameObject.tag == "Player2")
        {
            canBePressed = false;
        }
    }
}
