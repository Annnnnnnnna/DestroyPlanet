using UnityEngine;
using UnityEngine.UI;

public class PlanetsController : MonoBehaviour
{
    public GameObject planetPrefab;
    public Material[] material;
    public Text TextToDisplay;
    int count = 0;
    Renderer rend;

    void Start()
    {
        TextToDisplay.GetComponent<Text>().enabled = false;
        string elements = MenuController.elem;
        int N = int.Parse(elements);

        for (int i = 0; i < N - 1; i++)
        {
            Vector3 position = new Vector3(Random.Range(-8.0F, 8.0F), Random.Range(-3.0F, 3.0F), 0);
            Instantiate(planetPrefab, position, Quaternion.identity).transform.Rotate(Vector3.forward * Random.Range(0.1F, 3.0F));
            planetPrefab.gameObject.transform.localScale = new Vector3(Random.Range(0.1F, 3.0F), Random.Range(0.1F, 3.0F), 0);

            rend = planetPrefab.GetComponent<Renderer>();
            rend.enabled = true;
            rend.sharedMaterial = material[Random.Range(0, 7)];
        }
    }

    void Update()
    {
        if (GameObject.FindObjectsOfType(typeof(Planet)).Length == 0 && count < 1)
        {
            float time = Time.time;
            TextToDisplay.GetComponent<Text>().enabled = true;
            TextToDisplay.text = " You win!\n Your time: " + time + "s";
            count = 1;
        }
    }

}