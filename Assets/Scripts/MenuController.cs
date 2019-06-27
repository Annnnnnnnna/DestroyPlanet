using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour {

    public InputField mainInputField;
    public static string elem;

    public void Start()
    {
        mainInputField.onEndEdit.AddListener(delegate {  elem = mainInputField.text; });

    }
    public void LoadOnClick()
    {
        SceneManager.LoadScene("game_planet", LoadSceneMode.Single);
    }
}
