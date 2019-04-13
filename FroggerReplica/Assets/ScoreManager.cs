using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{

    public InputField userInfo;
    private string txtConents;
    public string userName;
    private TextAsset asset;

    // Start is called before the first frame update
    public void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void WriteString()
    {
        userInfo.text = userName;

        string path = "Assets/Resources/test.txt";

        //Write some text to the test.txt file
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine(userInfo.text);
        writer.Close();

        //Re-import the file to update the reference in the editor
        AssetDatabase.ImportAsset(path);
        asset = (TextAsset)Resources.Load("test");

        txtConents = asset.text;

        //Print the text from the file
        //Debug.Log(asset.text);

    }

    public void ReadString()
    {
        string path = "Assets/Resources/test.txt";

        //Read the text from directly from the test.txt file
        StreamReader reader = new StreamReader(path);

        AssetDatabase.ImportAsset(path);
        asset = (TextAsset)Resources.Load("test");

        txtConents = asset.text;

        reader.Close();
    }

    void OnGUI()
    {

        if (SceneManager.GetActiveScene().name == "Scores")
        {
            var centeredStyle = GUI.skin.GetStyle("Label");
            centeredStyle.alignment = TextAnchor.UpperRight;
            GUI.Label(new Rect(Screen.width / 2 - 50, 0, 80, 500), txtConents);
        }

        if (SceneManager.GetActiveScene().name == "GameOverScene")
        {
            var centeredStyle = GUI.skin.GetStyle("Label");
            centeredStyle.alignment = TextAnchor.UpperCenter;
            GUI.Label(new Rect(Screen.width / 2 - 50, 150, 80, 500), txtConents);
        }
    }

    public void SaveScore()
    {
        string path = "Assets/Resources/test.txt";

        //Write some text to the test.txt file
        StreamWriter writer = new StreamWriter(path, true);
        writer.Write(Score.CurrentScore.ToString());
        writer.Close();

        //Re-import the file to update the reference in the editor
        AssetDatabase.ImportAsset(path);
        asset = (TextAsset)Resources.Load("test");

        txtConents = asset.text;
    }
}
