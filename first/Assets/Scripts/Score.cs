using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public Text HighScore;
    public float scoreNumber;

    // Update is called once per frame
    void Start()
    {
        HighScore.text = PlayerPrefs.GetFloat("HighScore",0).ToString("0");
    }
    void Update()
    {;
        scoreText.text = player.position.z.ToString("0");
        
        scoreNumber = player.position.z;

        if(scoreNumber > PlayerPrefs.GetFloat("HighScore", 0)){
            PlayerPrefs.SetFloat("HighScore", scoreNumber);
            HighScore.text = scoreNumber.ToString("0");
        }

    }
}
