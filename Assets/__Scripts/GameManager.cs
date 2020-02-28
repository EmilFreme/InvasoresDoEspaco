using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public Level[] levels;
    private int activeLevel;
    public Transform enemyCommander;


    public static int ScreenBounds = 8;


    private static GameManager _instance;
    public static GameManager Instance {
        get {
            if (_instance == null) return null;
            return _instance;
        }
        set {
            if (_instance != null) Debug.LogError("Erro tentando setar o singleton de novo");
            _instance = value;
        }
    }

    private void Awake()
    {
        GameManager.Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        activeLevel = 0;
        LoadLevel();
    }

    void LoadLevel()
    {
        for (int i = 0; i < levels[activeLevel].enemyRows.Length; i++)
        {
            int[] row = levels[activeLevel].parseEnemyRows(i);
            for(int j = 0; j < row.Length; j++)
            {
                if (row[j] < 0) continue;
                GameObject enemy = levels[activeLevel].types[row[j]];

                Vector2 spriteSize = enemy.GetComponent<SpriteRenderer>().size;

                

                Vector3 position = new Vector3(-8+16/row.Length*j, 4.5f-1 * i, 0);

                if (enemy) Instantiate(enemy, position, Quaternion.identity, enemyCommander);
            }
        }
    }

    public void NextLevel()
    {
        if (++activeLevel > levels.Length) EndGame();
        enemyCommander.position = Vector3.zero;
        LoadLevel();
    }

    public static void EndGame()
    {

    }
}
