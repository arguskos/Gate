using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameflow : MonoBehaviour {

    // Use this for initialization
    private int _level;
    private int _levels = 1;
    private int _currentObject;
    public int[] LevelAmmountIems;
    public GameObject[] GameObjects ;

    public GameObject ObjectSpawner;
    public bool GameOver = false;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Spawn()
    {
        if (!GameOver)
        {
            int id = Random.Range(1, 10);
            ObjectSpawner.GetComponent<ObjectCreation>().Spawn(GameObjects[_currentObject], id);
            _currentObject++;
            if (_currentObject >= LevelAmmountIems[_level])
            {
                _level++;
                if (_level == _levels)
                {
                    Debug.Log("ENDING");
                    GameOver = true;
                }
            }
        }
    }
}
