using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class Http : MonoBehaviour
{
    public void PostRequest(string roomName)
    {
        WebRequest request = WebRequest.Create("https://crucial-guard-329316.uc.r.appspot.com/");
        request.Method = "POST";
        request.Headers.Add("room_name", roomName);

        WebResponse response = request.GetResponse();
        response.Close();
    }
}
