using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Base playerBase;
    private bool youLost = false;
    private int cash = 0;

    private void Start()
    {
        SpawnEnemies();

        if (playerBase == null) Debug.LogError("Base is null");
    }

    private void GameOver(bool b, int baseHealth)
    {
        //GameManager cannot access Base's baseHealth due to its protection level
        //And if it could, GameOver() would have to be called every frame due to the lack of an event in Base
    }

    private void SpawnEnemies()
    {
        Debug.LogWarning("SpawnEnemies unimplemented");
    }
}
