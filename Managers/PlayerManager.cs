using Unity.VisualScripting;
using UnityEngine;

[System.Serializable]
public struct PlayerData {
    public Vector3 position;
}
public class PlayerManager : MonoBehaviour
{
    // Static instance of GameManager
    public static PlayerManager Instance { get; private set; }

    public PlayerData playerData = new();

    // why is this so well commented it looks ai :sob: I SWEAR I WROTE THIS LOL
    private void Awake()
    {
        // Check if Instance already exists
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Persist between scenes
        }
        else
        {
            Destroy(gameObject); // Enforce singleton pattern
        }

    }
}
