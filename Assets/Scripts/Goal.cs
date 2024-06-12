using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [Tooltip("Scene to load when the player collides with the goal")]
    [SerializeField]
    string NextScene = "default";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameStateManager.Instance.onGoal(NextScene);
        }
    }
}
