using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
    private void OnTriggerEnter2D (Collision2D collision)
    {
        SceneManager.LoadScene(1);
    }
}
