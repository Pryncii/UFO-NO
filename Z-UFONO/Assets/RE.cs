using UnityEngine.SceneManagement;
using UnityEngine;

public class RE : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Title()
    {
        SceneManager.LoadScene("MENU");
    }
}
