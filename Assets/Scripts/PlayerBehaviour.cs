using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{

    public LayerMask stopsMovement;

    private bool keyDown = false;
    private Dictionary<string, Vector3> moveMap = new Dictionary<string, Vector3>();

    // Start is called before the first frame update
    void Start()
    {
        // Rogue keys
        moveMap.Add("y", new Vector3(-1f, 1f));
        moveMap.Add("k", new Vector3(0f, 1f));
        moveMap.Add("u", new Vector3(1f, 1f));
        moveMap.Add("h", new Vector3(-1f, 0f));
        moveMap.Add("l", new Vector3(1f, 0f));
        moveMap.Add("b", new Vector3(-1f, -1f));
        moveMap.Add("j", new Vector3(0f, -1f));
        moveMap.Add("n", new Vector3(1f, -1f));

    }

    // Update is called once per frame
    void Update()
    {
        foreach (KeyValuePair<string, Vector3> movePair in moveMap)
        {
            if (Input.GetKeyUp(movePair.Key))
            {
                keyDown = false;
            }
        }
            
        if (keyDown)
        {
            return;
        }

        foreach (KeyValuePair<string, Vector3> movePair in moveMap)
        {
            if (Input.GetKeyDown(movePair.Key))
            {
                checkAndMove(movePair.Value);
                Debug.Log(String.Format("{0}, {1}", transform.position.x, transform.position.y));
            }
        }
    }

    void checkAndMove(Vector3 change)
    {
        if (Physics2D.OverlapCircle(transform.position + change, .2f, stopsMovement))
        {
            Debug.Log("Stop Movement.");
        }
        else
        {
            transform.position += change;
            keyDown = true;
        }
    }
}
