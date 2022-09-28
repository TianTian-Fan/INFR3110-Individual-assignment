using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemGreen : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            ScoreManager.instance.ChangeScore(100);
            Debug.Log("You found a green gem!");
            Destroy(gameObject);
        }
    }
}
