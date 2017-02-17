using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameflow : MonoBehaviour {

    // Use this for initialization
    private int _level;
    private int _levels = 2;
    private int _currentObject;
    public int[] LevelAmmountIems;
    public CameraHelper CameraHelper;
    public GameObject ObjectSpawner;
    public bool GameOver = false;
	void Start () {
        CameraHelper.UpdateText("Packages Left: " + (LevelAmmountIems[_level] - _currentObject).ToString());

    }

    // Update is called once per frame
    void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
        {
            Application.LoadLevel(0);
        }
    }
    public void Spawn()
    {
        if (!GameOver)
        {
            int id = Random.Range(1, 10);
            ObjectSpawner.GetComponent<ObjectCreation>().Spawn( id);
            _currentObject++;

            CameraHelper.UpdateText("Packages Left: " + (LevelAmmountIems[_level] - _currentObject).ToString());
            if (_currentObject >= LevelAmmountIems[_level])
            {
                _level++;
                _currentObject = 0;

                if (_level == _levels)
                {
                    Debug.Log("ENDING");
                    CameraHelper.UpdateText("Game Over");
                    GameOver = true;
                   // Application.LoadLevel(0);
                }
                if (!GameOver)
                    CameraHelper.UpdateText("Packages Left: " + (LevelAmmountIems[_level] - _currentObject).ToString());

            }
        }
    }
}
