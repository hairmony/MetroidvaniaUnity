using UnityEngine;
using UnityEngine.SceneManagement;

public class RoomManager : MonoBehaviour
{
    public string sceneToLoad;

    public Vector2 newPlayer1Position;
    public Vector2 newPlayer2Position;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (!string.IsNullOrEmpty(sceneToLoad))
            {
                ScenePosition.nextSpawnPosition1 = newPlayer1Position;
                ScenePosition.hasSpawnPosition1 = true;

                ScenePosition.nextSpawnPosition2 = newPlayer2Position;
                ScenePosition.hasSpawnPosition2 = true;

                SceneManager.LoadScene(sceneToLoad);
            }
        }
    }
}