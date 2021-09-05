using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : MonoBehaviour
{
    public Dialogue Dialogue;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Dialogue.DisplayDialogue("Stage Clear!!");
        }
    }
}
