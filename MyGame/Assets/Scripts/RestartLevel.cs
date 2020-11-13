using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    private Scene scene;

    void Start()
    {
        scene = SceneManager.GetActiveScene();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
#pragma warning disable CS0618 // Type or member is obsolete
            Application.LoadLevel(scene.name);
#pragma warning restore CS0618 // Type or member is obsolete
        }
    }
}
