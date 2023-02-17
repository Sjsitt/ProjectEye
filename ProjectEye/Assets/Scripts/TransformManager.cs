using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;


public class TransformManager : MonoBehaviour
{

    System.Random rnd = new System.Random();

    public static TransformManager Instance;

    void Awake()
    {
        Instance = this;
    }

    public Vector3[] Positions;

    private int? RandomIndex= null;

    public GameObject[] coin;

    public List<Transform> spawnPoints;
    // Start is called before the first frame update
    void Start()
    {

        spawnPoints = new List<Transform>(spawnPoints);
        SpawnCoins();

    }

    private void GetRandomNumber()
    {

        var test = Random.Range(0, Positions.Length - 1);

        if(RandomIndex == null)
        {
            RandomIndex = test;
        }
        else
        {
            if (RandomIndex != test)
            {
                RandomIndex = test;
            }
            else
            {
                GetRandomNumber();
            }
        }
           
    }

    public Vector3 MoveGameObject()
    {

        GetRandomNumber();

        Vector3 coinposition = Positions[RandomIndex.Value];

        Debug.Log("Coin Index:" + RandomIndex.Value);

        return coinposition;

    }


    public void SpawnCoins()
    {
        for (int i = 0; i < coin.Length; i++)
        {
            var spawn = Random.Range(0, spawnPoints.Count);
            Instantiate(coin[i], spawnPoints[spawn].transform.position, Quaternion.identity);
            spawnPoints.RemoveAt(spawn);
        }
    }


}
