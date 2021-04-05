using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    public Vector2 startPos;
    public float scrollSpeed = -3.15f;
    public float pastTime = 0f;
    public float deltaTime = 0f;
    public GameObject BottomObstacleBlue;
    public GameObject BottomObstacleBlueSlider;
    public GameObject BottomObstacleYellow;
    public GameObject BottomObstacleYellowSlider;
    public GameObject TopObstacleGreen;
    public GameObject TopObstacleGreenSlider;
    public GameObject TopObstacleRed;
    public GameObject TopObstacleRedSlider;


    [System.Serializable]
    public class notesDetails
    {
        public string name;
        public string time;
    }

    [System.Serializable]
    public class musicInteract
    {
        public notesDetails[] notes;
    }

    void Start()
    {
        float obstaclePosition = 0f;
        string json = File.ReadAllText(Application.dataPath + "/Scripts/cmonnotasALT.json");
        musicInteract musicJson = JsonUtility.FromJson<musicInteract>(json);
        pastTime = 15.29f;
        foreach (notesDetails noteInteraction in musicJson.notes)
        {
            GameObject prefab = null;
            deltaTime = 2 + float.Parse(noteInteraction.time) - pastTime;
            obstaclePosition += deltaTime;
            switch (noteInteraction.name)
            {
                case "PP":
                    prefab = Instantiate(TopObstacleGreen, new Vector3(obstaclePosition, 2f, 0), Quaternion.identity);
                    break;
                case "PPS":
                    prefab = Instantiate(TopObstacleGreenSlider, new Vector3(obstaclePosition, 2f, 0), Quaternion.identity);
                    break;
                case "P":
                    prefab = Instantiate(TopObstacleRed, new Vector3(obstaclePosition, 2f, 0), Quaternion.identity);
                    break;
                case "PS":
                    prefab = Instantiate(TopObstacleRedSlider, new Vector3(obstaclePosition, 2f, 0), Quaternion.identity);
                    break;
                case "D":
                    prefab = Instantiate(BottomObstacleBlue, new Vector3(obstaclePosition, -1.5f, 0), Quaternion.identity);
                    break;
                case "DS":
                    prefab = Instantiate(BottomObstacleBlueSlider, new Vector3(obstaclePosition, -1.5f, 0), Quaternion.identity);
                    break;
                case "E":
                    prefab = Instantiate(BottomObstacleYellow, new Vector3(obstaclePosition, -1.5f, 0), Quaternion.identity);
                    break;
                case "ES":
                    prefab = Instantiate(BottomObstacleYellowSlider, new Vector3(obstaclePosition, -1.5f, 0), Quaternion.identity);
                    break;
            }
            pastTime = float.Parse(noteInteraction.time);
            prefab.transform.SetParent(this.transform);
        }
        startPos = new Vector2(-2956f, -0.5f);
    }

    void Update()
    {
        float newPos = Mathf.Repeat(Time.time * scrollSpeed, 3000);
        // Debug.Log(newPos);
        transform.position = startPos + Vector2.right * newPos;

    }
}
