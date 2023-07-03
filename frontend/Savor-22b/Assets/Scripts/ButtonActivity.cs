using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Text
using TMPro; // Textmeshpro

using UnityEngine.Networking;
using GraphQlClient.Core;


public class ButtonActivity : MonoBehaviour
{

    public TMP_Text outputText;

    public GraphApi APIReference;

    public async void GetNodeStatus()
    {

        // Setting Query
        GraphApi.Query query = APIReference.GetQueryByName("getNodeStatus", GraphApi.Query.Type.Query);

        // Arugment Setting
        //query.SetArgs(new{name = pokemonName.text});

        // Request
        UnityWebRequest request = await APIReference.Post(query);
        outputText.text = HttpHandler.FormatJson(request.downloadHandler.text);

    }



    public void OnClickEventKTH()
    {
        GetNodeStatus();
        //outputText.text = "Button Clicked!";

    }
    // Start is called before the first frame update
    void Start()
    {
        outputText.text = "Button Ready";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
