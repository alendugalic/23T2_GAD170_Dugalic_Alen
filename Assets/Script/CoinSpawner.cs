
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    // The prefab that we want to initiate:
    [SerializeField] private GameObject CoinPrefab;

    //Update is called once per frame
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //when player presses "SpaceBar"
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //....spawn a coin!
            Instantiate(CoinPrefab, transform.position, Quaternion.identity, transform);

        }
    }
}
