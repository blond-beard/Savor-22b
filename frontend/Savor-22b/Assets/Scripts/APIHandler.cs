using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Networking;
using GraphQlClient.Core;


public class APIHandler : MonoBehaviour
{
    public GraphApi APIReference;

    public async void GetNodeStatus()
    {
        UnityWebRequest request = await APIReference.Post("GetNodeStatus", GraphApi.Query.Type.Query);

        string data = request.downloadHandler.text;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
