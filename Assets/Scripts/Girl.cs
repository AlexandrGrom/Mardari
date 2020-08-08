using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girl : MonoBehaviour
{
    private Vector3 startPosition;
    private float random;
    void Awake()
    {
        random = Random.Range(0f, 1f);
        startPosition = transform.position;
    }


    void Update()
    {
        if (GameStateManager.currentState == EStates.Game)
        {

            transform.position = new Vector3(startPosition.x, startPosition.y, startPosition.z * Mathf.Sin(Time.time + random));
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
           
        }
    }
}
