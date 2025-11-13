using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoomManager : MonoBehaviour
{
    public async void OnTriggerEnter2D(Collider2D collision)
    {
        //Only assumes 1 door per room
        if (collision.gameObject.CompareTag("Player"))
        {
            switch (SceneManager.GetActiveScene().name)
            {
                case "OpeningRoom":
                    await SceneManager.LoadSceneAsync("SecondRoom");
                    execute("SecondRoom");
                    break;
                case "SecondRoom":
                    await SceneManager.LoadSceneAsync("OpeningRoom");
                    execute("OpeningRoom");
                    break;
                default:
                    break;
            }
        }
    }

    void execute(string name)
    {
        SceneManager.SetActiveScene(SceneManager.GetSceneByName(name));
    }
}