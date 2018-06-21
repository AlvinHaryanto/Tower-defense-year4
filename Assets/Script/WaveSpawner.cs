using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class WaveSpawner : MonoBehaviour
{
    public static int EnemiesAlive = 0;

    public GameManage1 gameManager;

    public Wave[] waves;
    public Transform capungPrefab;
    public Transform kepikPrefab;
    public Transform semutPrefab;
    public Transform kelabangPrefab;
    public Transform enemyPrefab;
    public Transform spawnPoint;


    public float timeBetweenWaves = 8f;
    private float countdown = 3f;
    public Text waveCountdownText;

    private int waveIndex = 0;
    public int boss = 0;
    public int x = 0;
   
    public static bool GameIsOver;
    public GameObject gameOverUI;
    public GameObject completeLevelUI;


    void Start()
    {
        GameIsOver = false;
    }


    void Update()
    {
        if(EnemiesAlive > 0)
        {
            return;
        }

        if (waveIndex == waves.Length)
        {

            WinLevel();
            this.enabled = false;
            Debug.Log("Abis");
        }


        if (countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            //SpawnWave();
            countdown = timeBetweenWaves;
            return;
        }
        countdown -= Time.deltaTime;

        countdown = Mathf.Clamp(countdown, 0f, Mathf.Infinity);

        waveCountdownText.text = string.Format("{0:00.00}", countdown);
    }

    IEnumerator SpawnWave()
    {
        
        PlayerStats.Rounds++;

        Wave wave = waves[waveIndex];


        for (int i = 0; i < wave.count; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                SpawnEnemy(wave.enemy);
                yield return new WaitForSeconds(0.5f / wave.rate);
            }
        }
        /*
        for (int i = 0; i < waveIndex; i++)
        {
            SpawnCapung();
            yield return new WaitForSeconds(0.7f);
        }

        if (waveIndex % 4 == 0)
        {
            x++;
            for (int i = 0; i < x; i++)
            {
                SpawnSemut();
                yield return new WaitForSeconds(1f);
            }
        }

        if (waveIndex % 5 == 0)
        {
            boss++;
            for (int i = 0; i < boss; i++)
            {
                SpawnKelabang();
                yield return new WaitForSeconds(2f);
            }
        }*/
        waveIndex++;

       
    }

    public void WinLevel()
    {

        GameIsOver = true;
        completeLevelUI.SetActive(true);
        Debug.Log("Abis");
    }

    void SpawnEnemy(GameObject enemy)
    {
        Instantiate(enemyPrefab);
        EnemiesAlive++;
    }

    void SpawnCapung()
    {
        Instantiate(capungPrefab);
        EnemiesAlive++;
    }

    void SpawnKepik()
    {
        Instantiate(kepikPrefab);
        EnemiesAlive++;
    }

    void SpawnSemut()
    {
        Instantiate(semutPrefab);
        EnemiesAlive++;
    }

    void SpawnKelabang()
    {
        Instantiate(kelabangPrefab);
        EnemiesAlive++;
    }
}
