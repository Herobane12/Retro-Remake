using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (this.gameObject.CompareTag("Death Triggr"))
        {
            Destroy(collision.gameObject);
            SceneManager.LoadScene("Game Over");
        }
    }
}
