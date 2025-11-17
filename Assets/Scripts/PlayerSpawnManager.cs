using UnityEngine;

public class PlayerSpawnManager : MonoBehaviour
{
    public enum PlayerID
    {
        Player1,
        Player2
    }

    [Tooltip("Set this in the Inspector. Is this Player 1 or Player 2?")]
    public PlayerID playerID;

    void Awake()
    {
        // Player 1
        if (playerID == PlayerID.Player1)
        {
            if (ScenePosition.hasSpawnPosition1)
            {
                transform.position = ScenePosition.nextSpawnPosition1;
                ScenePosition.hasSpawnPosition1 = false;
            }
            else if (ScenePosition.hasSavedPlayerPosition1)
            {
                transform.position = ScenePosition.savedPlayerPosition1;
                ScenePosition.hasSavedPlayerPosition1 = false;
            }
        }
        // Player 2
        else
        {
            if (ScenePosition.hasSpawnPosition2)
            {
                transform.position = ScenePosition.nextSpawnPosition2;
                ScenePosition.hasSpawnPosition2 = false;
            }
            else if (ScenePosition.hasSavedPlayerPosition2)
            {
                transform.position = ScenePosition.savedPlayerPosition2;
                ScenePosition.hasSavedPlayerPosition2 = false;
            }
        }
    }
}