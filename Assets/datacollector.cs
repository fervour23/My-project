using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class datacollector : MonoBehaviour
{
    private float startTime;
    private bool hasLogged = false;

    private void Start()
    {
        startTime = Time.time;
    }

    public void OnLeftButtonPressed()
    {
        LogChoice("Left");
    }

    public void OnRightButtonPressed()
    {
        LogChoice("Right");
    }

    private void LogChoice(string choice)
    {
        if (hasLogged) return;

        float timeTaken = Time.time - startTime;
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;

        string logPath = Application.dataPath + "/PlayerChoices.csv";
        string header = "SceneIndex,Choice,TimeTaken(s)";
        string entry = $"{sceneIndex},{choice},{timeTaken:F2}";

        if (!File.Exists(logPath))
        {
            File.WriteAllText(logPath, header + "\n");
        }

        File.AppendAllText(logPath, entry + "\n");

        Debug.Log("Logged choice: " + entry);
        Debug.Log("CSV saved at: " + logPath); // ✅ This logs the file path
        Application.OpenURL("file://" + logPath); // ✅ This opens the CSV file directly
        hasLogged = true;
    }
}
