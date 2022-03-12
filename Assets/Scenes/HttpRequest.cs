using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using UnityEngine;

public class HttpRequest : MonoBehaviour
{
    private void Start()
    {
        PostRequestAsync();
    }

    public async Task PostRequestAsync()
    {
        WebRequest request = WebRequest.Create("http://localhost:8080/");
        request.Method = "POST";
        request.Headers.Add("room_name", "Room_1");

        WebResponse response = await request.GetResponseAsync();
        response.Close();
    }
}
