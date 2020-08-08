using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody rb;

    void Awake()
    {
        GameStateManager.currentState = EStates.Game;
        print(GameStateManager.currentState);
    
    }

    void Update()
    {
        rb.velocity = Vector3.zero;
        if (GameStateManager.currentState != EStates.Game) return;

        if (Input.GetMouseButton(0))
        {
            rb.velocity = Vector3.right * speed;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        GameStateManager.currentState = EStates.Win;
        print("you win");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out Girl a))
        {
            print("you lose");
            GameStateManager.currentState = EStates.Lose;
        }
    }
}
