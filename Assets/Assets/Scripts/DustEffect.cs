using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DustEffect : MonoBehaviour
{
    public GameObject hitg;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(hitg, transform.position, Quaternion.identity);
        if (collision.collider.CompareTag("Respawn"))
        {
            StickmanController.health = 0;
        }
        if (collision.collider.CompareTag("Finish") && StickmanController.health > 0)
        {
            SceneManager.LoadScene("Win");
        }
    }
}
