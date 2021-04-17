
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using UnityEngine.Windows.Speech;   // grammar recogniser
using UnityEngine.SceneManagement;


public class VoiceController : MonoBehaviour
{
    private GrammarRecognizer gr;

    // Start is called before the first frame update
    void Start()
    {  
        gr = new GrammarRecognizer(Path.Combine(Application.streamingAssetsPath, 
                                        "Grammar.xml"), 
                            ConfidenceLevel.Low);
        Debug.Log("Grammar loaded!");
        gr.OnPhraseRecognized += GR_OnPhraseRecognized;
        gr.Start();
        if (gr.IsRunning) Debug.Log("Recogniser running");
    }

    private void GR_OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        string item;
        string gamePhrase;
        StringBuilder message = new StringBuilder();
        Debug.Log("Recognised a phrase");
        // read the semantic meanings from the args passed in.
        SemanticMeaning[] meanings = args.semanticMeanings;

        foreach(SemanticMeaning meaning in meanings)
        {
            item = meaning.values[0].Trim();
            message.Append("gamePhrase: " + item);

            gamePhrase = item;

            switch(gamePhrase) {
                case "start":
                    StartGame();
                    break;
                case "stop":
                    QuitGame();
                    break;
                case "restart":
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                    break;
            }
        }
    }

    private void OnApplicationQuit()
    {
        if (gr != null && gr.IsRunning)
        {
            gr.OnPhraseRecognized -= GR_OnPhraseRecognized;
            gr.Stop();
        }
    }

    public void StartGame() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("In QuitGame()");
        Application.Quit();
    }
}
