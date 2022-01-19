using UnityEngine;
using UnityEngine.UI;

public class UpdateScore : MonoBehaviour
{

    public GameObject player;
    public Text scoreText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (true) {
            scoreText.text = "Current Score: " + player.transform.position.z.ToString("0");
        }
        
    }

}
