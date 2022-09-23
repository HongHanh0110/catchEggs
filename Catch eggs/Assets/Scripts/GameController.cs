using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject egg;
    public float spawnTime;// khoang thoi gian tao ra qua bong tiep theo
    float saveSpawnTime;
    int saveScore;
    bool isGameOver;

    UiManager ui; 
    public void SetGameOverState(bool state)
    {
        isGameOver = state;
    }


    // Start is called before the first frame update
    void Start()
    {
        saveSpawnTime  = 0;
        ui = FindObjectOfType<UiManager>();
        ui.SetScoreText("Score:" + saveScore);
    }

    // Update is called once per frame
    void Update()
    {
        saveSpawnTime = saveSpawnTime  - Time.deltaTime;
        if(isGameOver)
        {

            saveSpawnTime = 0;
            ui.ShowGameOverPanel(true);
            return;

        }


        if (saveSpawnTime  <= 0)
        {
            SpawnEgg();
            saveSpawnTime = spawnTime;
        }
        
    }

    public void SetScore(int value)
    {
        saveScore = value;
    }

    public int GetScore()
    {
        return saveScore;
    }

    public void IncrementScore()
    {
        saveScore++;
        ui.SetScoreText(" Score:" + saveScore);
    }
    public bool IsGameOver()
    {
        return isGameOver;
    }

    

    public void SpawnEgg()
    {
        Vector2 spawnPos = new Vector2(Random.Range(-12, 12), 6);
        if(egg)
        {
            Instantiate(egg, spawnPos, Quaternion.identity);
        }
    }

    public void RePlay()
    {
        saveScore = 0;
        isGameOver = false;
        ui.SetScoreText(" Score:" + saveScore);
        ui.ShowGameOverPanel(false);
    }
}
