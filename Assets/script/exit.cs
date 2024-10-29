using UnityEngine;

public class ExitButtonScript : MonoBehaviour
{
    // Fungsi untuk keluar dari aplikasi
    public void ExitGame()
    {
        Application.Quit();

        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}

