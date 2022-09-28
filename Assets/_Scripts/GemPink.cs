using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemPink : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            ScoreManager.instance.ChangeScore(50);
            Debug.Log("You found a pink gem!");
            Destroy(gameObject);
        }
    }
}
