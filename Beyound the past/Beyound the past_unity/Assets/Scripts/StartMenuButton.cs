using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuButton : MonoBehaviour
{
    public void StartButton() {
        SceneManager.LoadScene("Cena2");
    }
}
