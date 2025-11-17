using UnityEngine;

public class PlayerPositionSaver : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SavePositions();
        }
    }

    public void SavePositions()
    {
        if (player1 != null)
        {
            ScenePosition.savedPlayerPosition1 = player1.transform.position;
            ScenePosition.hasSavedPlayerPosition1 = true;
        }

        if (player2 != null)
        {
            ScenePosition.savedPlayerPosition2 = player2.transform.position;
            ScenePosition.hasSavedPlayerPosition2 = true;
        }
    }

    public void SavePositionsFromEditor()
    {
        if (player1 == null)
        {
            return;
        }
        if (player2 == null)
        {
            return;
        }

        SavePositions();
    }
}