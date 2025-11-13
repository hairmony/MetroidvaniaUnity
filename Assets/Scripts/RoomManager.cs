using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoomManager : MonoBehaviour
{
    public async void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(SceneManager.GetActiveScene().name);
        if (collision.gameObject.CompareTag("Player") && SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(0))
        {
            Debug.Log("Change");
            await SceneManager.LoadSceneAsync(1);
            execute(1);
        }
        else if(collision.gameObject.CompareTag("Player") && SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(1))
        {
            Debug.Log("Change Back");
            await SceneManager.LoadSceneAsync(0);
            execute(0);
        }
    }
    void execute(int i)
    {
        SceneManager.SetActiveScene(SceneManager.GetSceneByBuildIndex(i));
    }
}
