using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollisionHandler : MonoBehaviour
{
    public string SecondScene; // Nazwa docelowej sceny

    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene(SecondScene); // Za³aduj now¹ scenê
    }
}
